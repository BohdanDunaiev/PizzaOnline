using PizzaOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Services.UnitOfWork
{
    public interface ISQLsqlunitOfWork
    {
        ISQLOrderRepository SQLOrderRepository { get; }
        void Complete();
    }
}
