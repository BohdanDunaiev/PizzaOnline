using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline.DAL.Interfaces.EntityInterfaces;
using PizzaOnline.Models;

namespace PizzaOnline.DAL.Interfaces.SQLInterfaces.ISQLRepositories
{
    public interface ISQLOrderRepository: IGenericRepository<SQLOrder, int>
    {
    }
}
