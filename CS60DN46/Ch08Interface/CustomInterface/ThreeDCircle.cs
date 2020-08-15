using System;

namespace CustomInterface
{
	class ThreeDCircle : Circle, IDraw3D
	{
		public new string PetName { get; set; }
		public new void Draw() { Console.WriteLine("Drawing a 3D Circle"); }
		public void Draw3D() { Console.WriteLine("Drawing Circle in 3D!"); }
	}
}
