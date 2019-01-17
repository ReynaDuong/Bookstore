using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Database
{
	class BooksPerStore
	{
		public string Street { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string AuthorName { get; set; }

		public string BookTitle { get; set; }

		public int NumOfAvailability { get; set; }

		public override string ToString()
		{

			return $"{Street,-70}{City,-30}{State,-10}{BookTitle,-70}{AuthorName,-50}{NumOfAvailability,-15}\r\n";
		}
	}
}
