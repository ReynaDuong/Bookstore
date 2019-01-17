using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Database
{
	class Customer
	{
		public int CustomerID { get; set; }

		public string CustomerName { get; set; }

		public DateTime DateJoined { get; set; }

		public int UserName { get; set; }

		public int Password { get; set; }
	}
}
