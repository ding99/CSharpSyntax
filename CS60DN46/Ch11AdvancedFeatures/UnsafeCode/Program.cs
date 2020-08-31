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

			Console.WriteLine("statement: int* ptrInt = &myInt;");
			Console.WriteLine($"myInt : Value {myInt} / {*ptrInt}, Address: {(int)&myInt} / {(int)ptrInt}");
			Console.WriteLine($"ptrInt: Value {(int)ptrInt} / {(int)*(&ptrInt)}, Address: {(int)&ptrInt}");
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

/**
***** Pointer Types *****
=> Unsage scope
myInt: 25
myInt2: 10
=> Working with * and & operators
statement: int* ptrInt = &myInt;
myInt : Value 123 / 123, Address: 9696424 / 9696424
ptrInt: Value 9696424 / 9696424, Address: 9696420
Press any key to continue . . .
 **/