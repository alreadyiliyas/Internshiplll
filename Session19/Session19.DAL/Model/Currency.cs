using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19.DAL.Model
{
	public class Currency
	{
		public bool Success { get; set; }
		public string CurrencyCode { get; set; }
		public decimal CurrencyValue { get; set; }
		public DateTime lastUpdate { get; set; }
	}
}
