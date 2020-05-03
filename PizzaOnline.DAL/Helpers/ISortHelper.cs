using PizzaOnline.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaOnline.DAL.Helpers
{
    public interface ISortHelper<TEntity> where TEntity : class
    {
        IQueryable<TEntity> ApplySort(IQueryable<TEntity> entities, QueryStringParameters queryString);
    }
}
