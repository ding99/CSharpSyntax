using AutoLotDAL.ConnectedLayer;
using System;
using static System.Console;

namespace AdoNetTransaction {
	class Program {
		static void Main() {
			WriteLine("***** Simple Transaction Example *****");
			ForegroundColor = ConsoleColor.Yellow;

			bool throwEx = true;

			Write("Do you want to throw an exception (Y or N): ");
			var userAnswer = ReadLine();
			if (userAnswer?.ToLower() == "n")
				throwEx = false;

			var dal = new InventoryDAL();
			string connectString = @"Data Source=(local);Integrated Security=SSPI;Initial Catalog=AutoLot";
			dal.OpenConnection(connectString);

			dal.ProcessCreditRisk(throwEx, 5);
			WriteLine("Check CreditRisk table for results");

			ResetColor();
		}
	}
}
