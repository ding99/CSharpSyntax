using System;
using System.Data.SqlClient;

namespace FunWithStructs
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** Structs *****");

			FirstLook();
			ValueTypeAssignment();
			ReferenceTypeAssignment();
			ValueTypeContainingRefType();
			PassingValue();
			PassingRef();

			Console.ResetColor();
		}

		static void PassingRef()
		{
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Passing Person object by reference");

			Person m1 = new Person("Me1", 23);
			Console.Write("Before by ref call: "); m1.Display();
			SendPersonByRef(ref m1);
			Console.Write("After  by ref call: "); m1.Display();
		}
		static void SendPersonByRef(ref Person p)
		{
			p.age = 555; p = new Person("Nikki", 999);
		}

		static void PassingValue()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("=> Passing Person object by value");

			Person fred = new Person("Fred", 12);
			Console.Write("Before by value call, Person is: "); fred.Display();

			SendPersonByValue(fred);
			Console.Write("After  by value call, Person is: "); fred.Display();
		}
		static void SendPersonByValue(Person p)
		{
			p.age = 90; p = new Person("Nikki", 99);
		}

		static void ValueTypeContainingRefType()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("-> Creating r1");
			Rectangle r1 = new Rectangle("First Rect", 10, 10, 50, 50);
			Console.WriteLine("-> Assigning r2 to r1");
			Rectangle r2 = r1;
			r1.Display(); r2.Display();

			Console.WriteLine("-> Changing values of r2");
			r2.rect.infoString = "This is new infor"; r2.rectBottom = 4444;
			r1.Display(); r2.Display();
		}

		static void ReferenceTypeAssignment()
		{
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Assigning reference types");

			PointRef p1 = new PointRef(10, 10);
			PointRef p2 = p1;

			p1.Display(); p2.Display();
			p1.X = 100; Console.WriteLine("-> Changed p1.X");
			p1.Display(); p2.Display();
		}


		static void ValueTypeAssignment()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Assigning value types");

			Point p1 = new Point(10, 10);
			Point P2 = p1;

			p1.Display(); P2.Display();

			p1.X = 100;
			Console.WriteLine("-> Changed p1.X");
			p1.Display(); P2.Display();
		}

		static void FirstLook()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Point myPoint; myPoint.X = 349; myPoint.Y = 76; myPoint.Display();
			myPoint.Increment(); myPoint.Display();

			Point p1 = new Point(); p1.Display();
		}

		struct Point
		{
			public int X, Y;
			public Point(int XPos, int Ypos) { X = XPos; Y = Ypos; }
			public void Increment() { X++; Y++; }
			public void Decrement() { X--; Y--; }
			public void Display() { Console.WriteLine($"X = {X}, Y = {Y}"); }
		}

		class PointRef
		{
			public int X, Y;
			public PointRef(int XPos, int YPos) { X = XPos; Y = YPos; }
			public void Increment() { X++; Y++; }
			public void Decrement() { X--; Y--; }
			public void Display() { Console.WriteLine($"X = {X}, Y = {Y}"); }
		}

		struct Rectangle
		{
			public Shape rect;
			public int rectTop, rectLeft, rectBottom, rectRight;
			public Rectangle(string info, int top, int left, int bottom, int right)
			{
				rect = new Shape(info);
				rectTop = top; rectLeft = left; rectBottom = bottom; rectRight = right;
			}
			public void Display()
			{
				Console.WriteLine($"String = {rect.infoString}, Top = {rectTop}, Bottom = {rectBottom}, Left = {rectLeft}, Right = {rectRight}");
			}
		}

		class Shape
		{
			public string infoString;
			public Shape(string info) { infoString = info; }
		}

		class Person
		{
			public string name; public int age;
			public Person(string _name, int _age) { name = _name; age = _age; }
			public void Display() { Console.WriteLine($"Name: {name}, Age: {age}"); }
		}
	}
}
