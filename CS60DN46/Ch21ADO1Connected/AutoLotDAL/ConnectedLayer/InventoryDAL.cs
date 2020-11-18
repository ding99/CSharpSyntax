using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AutoLotDAL.Models;

namespace AutoLotDAL.ConnectedLayer {
	public class InventoryDAL {
		private SqlConnection _sqlConnection = null;

		public void OpenConnection(string connectionString) {
			_sqlConnection = new SqlConnection { ConnectionString = connectionString };
			_sqlConnection.Open();
		}

		public void InsertAuto(NewCar car) {
			string sql = "Insert Into Inventory" + $"(Make, Color, PetName) Values ('{car.Make}', '{car.Color}', '{car.PetName}')";

			using(SqlCommand command =  new SqlCommand(sql, _sqlConnection)) {
				command.ExecuteNonQuery();
			}
		}

		public void DeleteCar(int id) {
			string sql = $"Delete from Inventory where CarId = '{id}'";
			using(SqlCommand command = new SqlCommand(sql, _sqlConnection)) {
				try {
					command.ExecuteNonQuery();
				}
				catch(SqlException ex) {
					Exception error = new Exception("Sorry! That car is on order!", ex);
					throw error;
				}
			}
		}

		public void UpdateCarPetName(int id, string newPetName) {
			string sql = $"Update Inventory Set PetName = '{newPetName}' Where CarId = '{id}'";
			using (SqlCommand command = new SqlCommand(sql, _sqlConnection))
				command.ExecuteNonQuery();
		}

		public List<NewCar> GetAllInventoryAsList() {
			List<NewCar> inv = new List<NewCar>();

			string sql = "Select * From Inventory";
			using (SqlCommand command = new SqlCommand(sql, _sqlConnection)) {
				SqlDataReader reader = command.ExecuteReader();
				while (reader.Read())
					inv.Add(new NewCar {
						CarId = (int)reader["CarId"],
						Color = (string)reader["Color"],
						Make = (string)reader["Make"],
						PetName = (string)reader["PetName"]
					});
				reader.Close();
			}

			return inv;
		}

		public DataTable GetAllInventoryAsDataTable() {
			DataTable table = new DataTable();

			string sql = "Select * From Inventory";
			using (SqlCommand command = new SqlCommand(sql, _sqlConnection)) {
				SqlDataReader reader = command.ExecuteReader();
				table.Load(reader);
				reader.Close();
			}

			return table;
		}

		public void CloseConnection() {
			_sqlConnection.Close();
		}
	}
}
