using Dapper;
using PizzaOnline.DAL.Interfaces;
using PizzaOnline.DAL.Interfaces.EntityInterfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PizzaOnline.DAL.Repositoryes
{
    public class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : IEntity<TId>
    {
        protected IConnectionFactory _connectionFactory;
        private readonly string _tableName;

        public GenericRepository(IConnectionFactory connectionFactory, string tableName)
        {
            _connectionFactory = connectionFactory;
            _tableName = tableName;
        }
        public IEnumerable<TEntity> GetAll()
        {
            var query = "GetAllOrders";
            using (var db = _connectionFactory.GetSqlConnection)
            {
                return db.Query<TEntity>(query,
                    new { P_tableName = _tableName },
                    commandType: CommandType.StoredProcedure);
                
            }
        }
        public TEntity Get(TId Id)
        {
            var query = "GetOrderById";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                return db.Query<TEntity>(query,
                    new { P_tableName = _tableName, P_Id = Id },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
        public void Delete(TId Id)
        {
            var query = "Delete";

            using (var db = _connectionFactory.GetSqlConnection)
            {
                db.Query<TEntity>(query,
                new { P_tableName = _tableName, P_Id = Id },
                commandType: CommandType.StoredProcedure);
            }
        }
        //public int Add(TEntity entity)
        //{
        //    var columns = GetColumns();
        //    var stringOfColumns = string.Join(", ", columns);
        //    var stringOfProperties = string.Join(", ", columns.Select(e => "@" + e));
        //    var query = "SP_Add";

        //    using (var db = _connectionFactory.GetSqlConnection)
        //    {
        //        var InsertionStatement = db.Query<string>(
        //            sql: query,
        //            param: new { P_tableName = _tableName, P_columnsString = stringOfColumns, P_propertiesString = stringOfProperties },
        //            commandType: CommandType.StoredProcedure).FirstOrDefault();

        //        var InsertedEntityId = db.Execute(
        //            sql: InsertionStatement,
        //            param: entity,
        //            commandType: CommandType.Text);

        //        return InsertedEntityId;
        //    }
        //}
        public void Update(TEntity entity)
        {
            var columns = GetColumns();
            var stringOfColumns = string.Join(", ", columns.Select(e => $"{e} = @{e}"));

            using (var db = _connectionFactory.GetSqlConnection)
            {
                //var query = "SP_UpdateRecordInTable";
                var query = "Update";

                var UpdateStatement = db.Query<string>(
                    sql: query,
                    param: new { P_tableName = _tableName, P_columnsString = stringOfColumns, P_Id = entity.Id },
                    commandType: CommandType.StoredProcedure).FirstOrDefault();

                db.Execute(
                    sql: UpdateStatement, 
                    param: entity,
                    commandType: CommandType.Text);
            }
        }
        private IEnumerable<string> GetColumns()
        {
            return typeof(TEntity)
                    .GetProperties()
                    .Where(e => e.Name != "Id" && !e.PropertyType.GetTypeInfo().IsGenericType)
                    .Select(e => e.Name);
        }
    }
}
