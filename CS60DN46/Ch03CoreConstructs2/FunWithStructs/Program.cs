﻿using System;
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

			Console.ResetColor();
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
	}
}
