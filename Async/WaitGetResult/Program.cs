using System;
using System.Threading.Tasks;

namespace WaitGetResult
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Async Test job:");
            Console.WriteLine("main start..");

            Console.WriteLine("MyMethod() running async method synchronously");

            Console.WriteLine("start to wait Wait");
            MyMethod().Wait(); //waiting till the async method completed

            int i = -1;
            Console.WriteLine("i:" + i);
            Console.WriteLine("start to wait GetAwaiter");
            i = MyMethod().GetAwaiter().GetResult(); //get the result of async method
            Console.WriteLine("i:" + i);

            Console.WriteLine("main end..");
            Console.ReadKey(true);
        }

        static async Task<int> MyMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Async start:" + i.ToString() + "..");
                await Task.Delay(1000); //delay simulation
            }
            return 0;
        }

    }
}
