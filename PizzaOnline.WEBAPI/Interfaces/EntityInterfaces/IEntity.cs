using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Interfaces.EntityInterfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
    