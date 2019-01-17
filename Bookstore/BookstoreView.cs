using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookstore.Database;

namespace Bookstore
{
	public partial class BookStoreViewMainPanel : Form
	{
		List<BooksPerStore> result { set; get; }

		public BookStoreViewMainPanel()
		{
			InitializeComponent();
			result = new List<BooksPerStore>();
		}

		private void Search_Click(object sender, EventArgs e)
		{
			BookstoreModel bookstoreModel = new BookstoreModel();

			// get conditions
			string bookName = this.BookName.Text;
			string authorName = this.AuthorName.Text;
			string ISBN = this.ISBN.Text;

			result = bookstoreModel.getResult(bookName, authorName, ISBN);
			result = sortResult();


			string resultSet = "";

			resultSet =
				$"{"Street",-70}{"City",-30}{"State",-10}{"BookTitle",-70}{"AuthorName",-50}{"NumOfAvailability",-15}\r\n";

			foreach (var record in result)
			{
				resultSet += record.ToString();
			}

			this.SearchInStore.Text = resultSet;
		}


		private List<BooksPerStore> sortResult()
		{
			IEnumerable<BooksPerStore> rs;

			if (sortByCity.Checked)
			{
				if (sortAsc.Checked)
				{
					rs = result.OrderBy(r => r.City);
				}
				else
				{
					rs = result.OrderByDescending(r => r.City);
				}
			}
			else if (sortByBookTitle.Checked)
			{
				if (sortAsc.Checked)
				{
					rs = from r in result
					     orderby r.BookTitle
					     select r;
				}
				else
				{
					rs = from r in result
					     orderby r.BookTitle descending
						 select r;
				}
			}
			else
			{
				if (sortAsc.Checked)
				{
					rs = result.OrderBy(r => r.State);
				}
				else
				{
					rs = result.OrderByDescending(r => r.State);
				}
			}

			return rs.ToList();
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			this.BookName.Text = "";
			this.AuthorName.Text = "";
			this.ISBN.Text = "";
			this.SearchInStore.Text = "";
			result = new List<BooksPerStore>();
		}


	}
}
