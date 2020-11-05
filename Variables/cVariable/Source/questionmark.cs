using System;

namespace CVariable {

	public class Marks {
		public class SecretData {
			public string Password { get; set; }
			public string TelePhone { get; set; }
		}

		public class Person {
			public string Name { get; set; }
			public string Sex { get; set; }
			public Nullable<int> Age { get; set; }
			public SecretData Secret { get; set; }
		}

		private Person p;
		private string tele = string.Empty;

		public Marks() { this.p = null;  }

		public bool TestMark() {

			Console.WriteLine("-- Step 1 (p is null)");

			Console.WriteLine("tele [" + (string.IsNullOrWhiteSpace(tele) ? "(null)" : tele) + "]");
			if(p == null)
				Console.WriteLine("p is null");
			else {
				if(p.Secret == null)
					Console.WriteLine("Secret is null");
				else {
					tele = p.Secret.TelePhone;
					Console.WriteLine("tele [" + tele + "]");
				}
			}

			Console.WriteLine("-- Step 2 (every defined)");
			p = new Person { Name = "John", Age = 30, Sex = "Male", Secret = new SecretData { Password = "pword", TelePhone = "123456" } };
			if(p == null)
				Console.WriteLine("p is null");
			else {
				if(p.Secret == null)
					Console.WriteLine("Secret is null");
				else {
					tele = p.Secret.TelePhone;
					Console.WriteLine("tele [" + tele + "]");
				}
			}

			Console.WriteLine("-- Step 3 (every defined, check every)");
			tele = p?.Secret?.TelePhone ?? "";
			Console.WriteLine("tele [" + tele + "]");

			Console.WriteLine("-- Step 4 (p is null)");
			p = null;
			tele = p?.Secret.TelePhone ?? "";
			Console.WriteLine("tele [" + tele + "]");

			Console.WriteLine("-- Step 5 (Secret is null, check every)");
			p = new Person { Name = "John", Age = 30, Sex = "Male", Secret = null };
			tele = p?.Secret?.TelePhone ?? "";
			Console.WriteLine("tele [" + tele + "]");

			Console.WriteLine("-- Step 6 (Secret is null, not check Secret)");
			p = new Person { Name = "John", Age = 30, Sex = "Male", Secret = null };
			try {
				tele = p?.Secret.TelePhone ?? "";
			} catch(Exception e) {
				Console.WriteLine("message {" + e.Message + "}");
				Console.WriteLine("trace   {" + e.StackTrace + "}");
			}
			Console.WriteLine("tele [" + tele + "]");

			return true;
		}
	}

}