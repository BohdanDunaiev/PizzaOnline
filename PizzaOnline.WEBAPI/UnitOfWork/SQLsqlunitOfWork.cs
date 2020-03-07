using PizzaOnline.DAL.Interfaces;
using PizzaOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.UnitOfWork
{
    public class SQLsqlunitOfWork : ISQLunitOfWork
    {
        private readonly ISQLOrderRepository _sqlOrderRepository;
        public SQLsqlunitOfWork(ISQLOrderRepository sqlOrderRepository)
        {
            _sqlOrderRepository = sqlOrderRepository;
        }

        public ISQLOrderRepository SQLOrderRepository
        {
            get
            {
                return _sqlOrderRepository;
            }
        }

        public void Complete()
        {
            throw new NotImplementedException();
        }
    }
}
