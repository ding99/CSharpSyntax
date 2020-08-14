using System;

namespace CustomInterface
{
	class Triangle : Shape, IPointy
	{
		public Triangle() { }
		public Triangle(string name) : base(name) { }
		public override void Draw()
		{
			Console.WriteLine($"Drawing {PetName} the Triangle");
		}

		public byte Points { get { return 3; } }
	}
}
