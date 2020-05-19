using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOnline.DAL.Models
{
    public class PizzaQueryParameters : QueryStringParameters
    {
        //const int maxPageSize = 10;
        //public int PageNumber { get; set; } = 1;
        //private int _pageSize = 2;
        //public int PageSize
        //{
        //    get
        //    {
        //        return _pageSize;
        //    }
        //    set
        //    {
        //        _pageSize = (value > maxPageSize) ? maxPageSize : value;
        //    }
        //}
        public decimal MinPrice { get; set; } = 0;
        public decimal MaxPrice { get; set; } = decimal.MaxValue;
        public bool ValidPriceRange => MaxPrice >= MinPrice && MinPrice >= 0;
        public string NamePizza { get; set; }
    }
}
