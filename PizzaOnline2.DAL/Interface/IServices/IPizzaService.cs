using System;
using System.Collections.Generic;
using System.Text;
using PizzaOnline2.DAL.Entities;

namespace PizzaOnline2.DAL.Interface.IServices
{
    public interface IPizzaService
    {
        IEnumerable<Pizza> GetAllPizza();
        Pizza GetByIdPizza(int id);
        void InsertPizza(Pizza obj);
        void UpdatePizza(Pizza obj);
        void DeletePizza(Pizza id);
    }
}
