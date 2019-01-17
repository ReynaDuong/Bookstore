using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Database
{
	class DatabaseManager
	{
		private readonly string _connectionString;

		public DatabaseManager(string serverName, string databaseName)
		{
			// Data Source=servername;Initial Catalog=databaseName;Trusted_connection=true;
			_connectionString = $"Data Source={serverName};Initial Catalog={databaseName};Trusted_connection=true;";
		}


		public DataTable ExecuteSelect(string query)
		{
			var table = new DataTable();
			using (var connection = new SqlConnection(_connectionString))
			{
				connection.Open();
				using (var sqlDataAdapter = new SqlDataAdapter(query, connection))
				{
					sqlDataAdapter.Fill(table);
				}
			}
			return table;
		}
		

	}
}
