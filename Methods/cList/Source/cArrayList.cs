using System;
using System.Collections;

namespace CList {
	public class checkArrayList {

        public void test() {
            ArrayList al = new ArrayList();

            #region numbers
            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
            Console.WriteLine($"Capacity {al.Capacity}, count {al.Count}");
            #endregion

            #region content
            Console.Write("Content:");
            foreach(int i in al)
                Console.Write(" " + i);
            Console.WriteLine();
            Console.Write("Sorted :");
            al.Sort();
            foreach(int i in al)
                Console.Write(" " + i);
            Console.WriteLine();
            #endregion
        }
	}
}
