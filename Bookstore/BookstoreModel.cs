using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookstore.Database;

namespace Bookstore
{
	class BookstoreModel
	{
		public List<BooksPerStore> getResult(string bookName, string authorName, string ISBN)
		{
			// query
			var query = @"SELECT s.Street, s.City, s.State,b.BookTitle,b.AuthorName, p.NumOfAvailability 
				            FROM dim.Stores s 
				            INNER JOIN fact.BookPerStore p 
								ON s.StoreID = p.StoreID 
				            INNER JOIN dim.Books b 
								ON b.BookID = p.BookID
							";

			bool[] conditions = new bool[3];
			conditions[0] = string.IsNullOrWhiteSpace(bookName);
			conditions[1] = string.IsNullOrWhiteSpace(authorName);
			conditions[2] = string.IsNullOrWhiteSpace(ISBN);

			string[] keys = new string[3];
			keys[0] = $"b.BookTitle = '{bookName}'\t";
			keys[1] = $"b.AuthorName = '{authorName}'\t";
			keys[2] = $"b.ISBN = '{ISBN}'\t";

			string conditionQuery = "WHERE ";
			string and = " AND ";
			bool firstCondition = true;

			for (int i = 0; i < 3; i++)
			{
				// if not null
				if (!conditions[i] && firstCondition)
				{
					conditionQuery += keys[i];
					firstCondition = false;
				}
				else if (!conditions[i] && !firstCondition)
				{
					conditionQuery = conditionQuery + and + keys[i];
				}
			}

			if (!firstCondition)
			{
				query += conditionQuery;
			}

			// get result set
			DatabaseManager database = new DatabaseManager(@"(LocalDb)\LocalDBDemo", "BookStore");

			var dt = database.ExecuteSelect(query);
			var result = new List<BooksPerStore>();

			foreach (DataRow row in dt.Rows)
			{
				result.Add(new BooksPerStore
				{
					AuthorName = row["AuthorName"].ToString(),
					BookTitle = row["BookTitle"].ToString(),
					Street = row["Street"].ToString(),
					City = row["City"].ToString(),
					State = row["State"].ToString(),
					NumOfAvailability = int.Parse(row["NumOfAvailability"].ToString())
				});
			}

			return result;
		}
	}
}