using System;

namespace SimpleClass
{
	class Motor
	{
		public int intensity;
		public string name;

		public Motor() { Console.WriteLine("In default ctor"); }
		public Motor(int intensity) : this(intensity, "")
		{
			Console.WriteLine("In ctor taking an int");
		}
		public Motor(string name) : this(0, name)
		{
			Console.WriteLine("In ctor taking a string");
		}
		public Motor(int intensity, string name)
		{
			Console.WriteLine("In master ctor ");
			this.intensity = intensity > 10 ? 10 : intensity;
			this.name = name;
		}

		public void SetDriverName(string name) { this.name = name; }

		public void PopAWheely()
		{
			for (int i = 0; i < intensity; i++)
				System.Console.WriteLine("Yeeeeeee Haaaaaaeeww!"); ;
		}
	}
}
