using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AutoLotDAL.ConnectedLayer {
	public class InventoryDAL {
		private SqlConnection _sqlConnection = null;

		public void OpenConnection(string connectionString) {
			_sqlConnection = new SqlConnection { ConnectionString = connectionString };
			_sqlConnection.Open();
		}

		public void CloseConnection() {
			_sqlConnection.Close();
		}
	}
}
