using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session19.BLL.Model
{
	public class AccountDTO
	{
		public int ID { get; set; }
		public string Login { get; set; }
		public string Password { get; set; }
		public DateTime CreatedDate { get; set; }

	}
}
