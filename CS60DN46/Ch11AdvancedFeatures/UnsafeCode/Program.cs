using System;

namespace UnsafeCode {
	class Program {
		static void Main() {
			Console.WriteLine("***** Pointer Types *****");
			unsafe {
				UnsafeScope();
				PrintValueAndAddress();
				Swaps();
				UsePointerToPoint();
				UnsafeStackAlloc();
				UseAndPinPoint();
				Sizeof();
			}
			Console.ResetColor();
		}

		static void Sizeof() {
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("-> Safe sizeof()");
			Console.WriteLine($"sizeof: short {sizeof(short)}, int {sizeof(int)}, long {sizeof(long)}");

			Console.WriteLine("-> Unsafe sizeof()");
			unsafe {
				Console.WriteLine($"The size of Point is {sizeof(Point)}");
			}
		}

		unsafe static void UseAndPinPoint() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Pinning a Type via the fixed Keyword");

			PointRef pt = new PointRef();
			pt.x = 5; pt.y = 6;
			
			//Pin pt in place so it will not be moved or GC-ed.
			fixed (int* p = &pt.x) {
				// Use int* variable here.
			}

			//pt is now unpinned.
			Console.WriteLine($"Point is: {pt}");
		}

		unsafe static void UnsafeStackAlloc() {
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("=> stackalloc keyword");

			char* p = stackalloc char[16];
			for (int k = 0; k < 16; k++) p[k] = (char)k;
			for (int k = 0; k < 16; k++) Console.Write($" {k}");
			Console.WriteLine();
		}

		unsafe static void UsePointerToPoint() {
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.WriteLine("=> Field Access via Pointers");

			Point point; Point* p = &point;
			p->x = 10; p->y = 20; Console.WriteLine(p->ToString());

			Point point2; Point* p2 = &point2;
			(*p2).x = 50; (*p2).y = 60; Console.WriteLine((*p2).ToString());
		}

		static void Swaps() {
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("=> Unsafe and Safe Swap functions");

			int i = 10, j = 20; Console.WriteLine($"i {i}, j {j}");
			
			Console.WriteLine("-> Safe swap"); SafeSwap(ref i, ref j);
			Console.WriteLine($"i {i}, j {j}");

			Console.WriteLine("-> Unsafe swap"); unsafe { UnsafeSwap(&i, &j); }
			Console.WriteLine($"i {i}, j {j}");
		}

		unsafe static void UnsafeSwap(int* i, int* j) {
			int temp = *i; *i = *j; *j = temp;
		}
		static void SafeSwap(ref int i, ref int j) {
			int temp = i; i = j; j = temp;
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