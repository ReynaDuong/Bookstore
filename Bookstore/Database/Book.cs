using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Database
{
	class Book
	{
		public int BookID { get; set; }

		public string ISBN { get; set; }

		public string BookTitle { get; set; }

		public string AuthorName { get; set; }

		public string Publisher { get; set; }

		public double Price { get; set; }


	}
}
