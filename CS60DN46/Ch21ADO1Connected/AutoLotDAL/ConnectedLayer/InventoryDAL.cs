﻿using AutoLotDAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.Console;

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

		public void InsertAuto(int id, string color, string make, string petName) {
			string sql = "Insert Into Inventory" + "(Make, Color, PetName) Values" + "(@Make, @Color, @PetName)";

			using(SqlCommand command = new SqlCommand(sql, _sqlConnection)) {
				SqlParameter parameter = new SqlParameter {
					ParameterName = "@Make",
					Value = make,
					SqlDbType = SqlDbType.Char,
					Size = 10
				};
				command.Parameters.Add(parameter);

				parameter = new SqlParameter {
					ParameterName = "@Color",
					Value = color,
					SqlDbType = SqlDbType.Char,
					Size = 10
				};
				command.Parameters.Add(parameter);

				parameter = new SqlParameter {
					ParameterName = "@PetName",
					Value = petName,
					SqlDbType = SqlDbType.Char,
					Size = 10
				};
				command.Parameters.Add(parameter);

				command.ExecuteNonQuery();
			}
		}

		public string LookUpPetName(int carID) {
			string carPetName = string.Empty;

			using(SqlCommand command = new SqlCommand("GetPetName", _sqlConnection)) {
				command.CommandType = CommandType.StoredProcedure;

				SqlParameter param = new SqlParameter {
					ParameterName = "@carID",
					SqlDbType = SqlDbType.Int,
					Value = carID,
					Direction = ParameterDirection.Input
				};
				command.Parameters.Add(param);

				param = new SqlParameter {
					ParameterName = "@petName",
					SqlDbType = SqlDbType.Char,
					Size = 10,
					Direction = ParameterDirection.Output
				};
				command.Parameters.Add(param);

				command.ExecuteNonQuery();

				carPetName = (string)command.Parameters["@petName"].Value;
			}

			return carPetName;
		}

		public void ProcessCreditRisk(bool throwEx, int custID) {
			#region look up current name
			string fName, lName;
			string sql = $"Select * from Customers where CustId = {custID}";
			var cmdSelect = new SqlCommand(sql, _sqlConnection);

			using(var reader = cmdSelect.ExecuteReader()) {
				if (reader.HasRows) {
					reader.Read();
					fName = (string)reader["FirstName"];
					lName = (string)reader["LastName"];
				} else return;
			}
			#endregion

			#region transaction
			sql = $"Delete from Customers where CustId = {custID}";
			var cmdRemove = new SqlCommand(sql, _sqlConnection);
			sql = $"Insert Into CreditRisks" + $"(FirstName, LastName) Values('{fName}','{lName}')";
			var cmdInsert = new SqlCommand(sql, _sqlConnection);

			SqlTransaction tx = null;
			try {
				tx = _sqlConnection.BeginTransaction();

				cmdInsert.Transaction = tx;
				cmdRemove.Transaction = tx;

				cmdInsert.ExecuteNonQuery();
				cmdRemove.ExecuteNonQuery();

				if(throwEx)
					throw new Exception("Sorry! Database error! Tx failed...");

				tx.Commit();
			}
			catch (Exception ex) {
				WriteLine(ex.Message);
				tx?.Rollback();
			}
			#endregion
		}

		public void CloseConnection() {
			_sqlConnection.Close();
		}
	}
}
