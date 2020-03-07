using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories;

namespace PizzaOnline.DAL.Interfaces
{
    public interface ISQLunitOfWork
    {
        ISQLOrderRepository SQLOrderRepository { get; }
        
        void Complete();
    }
}
