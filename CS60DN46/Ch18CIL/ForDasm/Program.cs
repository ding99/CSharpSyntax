
namespace ForDasm {
	class Program {
		static void Main() {
			System.Console.WriteLine("== Reference for DeAsm");
			Person jason = new Person();
			jason.Name = "Jason";
			jason.Age = 25;
			jason.Weight = 160.7;
			System.Console.WriteLine($"Name:{jason.Name}, Age:{jason.Age}, Weight:{jason.Weight}");
		}
	}
}
