namespace Shapes
{
	abstract class Shape
	{
		public string PetName { get; set; }
		public Shape(string name = "Noname") { PetName = name; }
		public abstract void Draw();
	}
}
