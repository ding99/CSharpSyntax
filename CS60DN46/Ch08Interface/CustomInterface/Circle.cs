namespace CustomInterface
{
	class Circle : Shape
	{
		public Circle() : base() { }
		public Circle(string name) : base(name) { }
		public override void Draw()
		{
			System.Console.WriteLine($"-- Drawing {PetName} the Circle");
		}
	}
}
