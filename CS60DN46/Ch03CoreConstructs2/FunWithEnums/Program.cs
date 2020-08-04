using System;

namespace FunWithEnums
{
	enum EmpType : byte
	{
		Manager = 10,
		Grunt = 1,
		Contractor = 100,
		VicePresident = 9
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Fun with Enums *****");

			Enums();
			EnumValues();

			Console.ResetColor();
		}
		
		static void EnumValues()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			EvaluateEnum(EmpType.Contractor);
			EvaluateEnum(DayOfWeek.Monday);
			EvaluateEnum(ConsoleColor.Gray);
			Console.WriteLine();
		}

		static void EvaluateEnum(Enum e)
		{
			Console.WriteLine("=> Information about {0}", e.GetType().Name);
			Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));
			Array enumData = Enum.GetValues(e.GetType());
			Console.Write("Members [{0}]:", enumData.Length);
			for (int i = 0; i < enumData.Length; i++)
				Console.Write(" {0}-{0:D}", enumData.GetValue(i));
			Console.WriteLine();
		}

		static void Enums()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			EmpType emp = EmpType.Contractor;
			AskForBonus(emp);

			Console.WriteLine("EmpType uses a {0} for storage.", Enum.GetUnderlyingType(emp.GetType()));
			Console.WriteLine("emp: Type (metadata description) is {0} / {1}",
				emp.GetType(), typeof(EmpType));
			Console.WriteLine("emp: name is {0} (string name), value is {1}",
				emp.ToString(), (byte)emp);
			Console.WriteLine("The value of {0} is {1} / {2}h", emp.ToString(),
				Enum.Format(typeof(EmpType), emp, "d"), Enum.Format(typeof(EmpType), emp, "x"));
			Console.WriteLine();
		}

		static void AskForBonus(EmpType e)
		{
			switch (e)
			{
				case EmpType.Manager:
					Console.WriteLine("How about stock options instead?");
					break;
				case EmpType.Grunt:
					Console.WriteLine("You have got to be kidding...");
					break;
				case EmpType.Contractor:
					Console.WriteLine("You already get enough cash...");
					break;
				case EmpType.VicePresident:
					Console.WriteLine("Very Good, sir!");
					break;
			}
		}
	}
}
