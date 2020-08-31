using System;

namespace UnsafeCode {
	class Program {
		static void Main() {
			Console.WriteLine("***** Pointer Types *****");
			UnsafeScope();
			PrintValueAndAddress();
			Console.ResetColor();
		}

		unsafe static void PrintValueAndAddress() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("=> Working with * and & operators");

			int myInt;
			int* ptrInt = &myInt;
			*ptrInt = 123;

			Console.WriteLine($"Value of myInt {myInt} / {*ptrInt}; Address of myInt {(int)ptrInt} / {(int)*(&ptrInt)}; Address of ptrInt {(int)&ptrInt}");
		}

		static void UnsafeScope() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Unsage scope");

			unsafe {	//work with pointer types here
				int myInt = 5;
				SquareIntPointer(&myInt);
				Console.WriteLine($"myInt: {myInt}");
			}

			//can't work with pointers here
			int myInt2 = 10;
			//SquareIntPointer(&myInt2);	//Compile error
			Console.WriteLine($"myInt2: {myInt2}");
		}

		unsafe static void SquareIntPointer(int* myIntPointer) {
			*myIntPointer *= *myIntPointer;
		}
	}
}
