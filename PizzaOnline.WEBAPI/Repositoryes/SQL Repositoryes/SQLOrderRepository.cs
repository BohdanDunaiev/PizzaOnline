using PizzaOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using PizzaOnline.DAL.Repositoryes;
using PizzaOnline.DAL.Interfaces;
using PizzaOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using PizzaOnline.DAL.Interfaces.EntityInterfaces;

namespace PizzaOnline.Repositoryes
{
    public class SQLOrderRepository : GenericRepository<SQLOrder, int>, ISQLOrderRepository
    {
        private static readonly string _tableName = "Orders";
        public SQLOrderRepository(IConnectionFactory connectionFactory) : base(connectionFactory, _tableName)
        {
            connectionFactory.SetConnection("server=KING;Initial Catalog=Pizzeria_online;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
