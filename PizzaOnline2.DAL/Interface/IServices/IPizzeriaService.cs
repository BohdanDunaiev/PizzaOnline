using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IPizzeriaService
    {
        IEnumerable<Pizzeria> GetAllPizzeria();
        Pizzeria GetByIdPizzeria(int id);
        void InsertPizzeria(Pizzeria obj);
        void UpdatePizzeria(Pizzeria obj);
        void DeletePizzeria(Pizzeria id);
    }
}
