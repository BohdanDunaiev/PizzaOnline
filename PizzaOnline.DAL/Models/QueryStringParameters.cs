using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PizzaOnline.DAL.Models
{
    public abstract class QueryStringParameters
    {
		const int maxPageSize = 100;
		public int PageNumber { get; set; } = 1;

		private int _pageSize = 20;
		public int PageSize
		{
			get
			{
				return _pageSize;
			}
			set
			{
				_pageSize = (value > maxPageSize) ? maxPageSize : value;
			}
		}

		public string OrderBy { get; set; }
	}
}
