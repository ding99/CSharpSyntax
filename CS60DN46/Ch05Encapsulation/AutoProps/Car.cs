using System;

namespace AutoProps
{
	class Car
	{
		public string Name { get; set; }
		public int Speed { get; set; }
		public string Color { get; set; }

		public void Display()
		{
			Console.WriteLine($"Car Name <{Name}>, Speed <{Speed}>, Color <{Color}>");
		}
	}
}
