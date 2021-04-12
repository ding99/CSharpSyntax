using System;
using System.Collections;

namespace HashTable{

    public class CType {
        public CType() { Console.ForegroundColor = ConsoleColor.DarkCyan; }

        public void test() {
            Hashtable table = new Hashtable();
            table.Add(100, "Value_01");
            table.Add("Name01", "Value_02");

            foreach(DictionaryEntry de in table)
                Console.WriteLine( $"Key [{de.Key.GetType()}],  Value [{de.Value.GetType()}]");
        }
    }

}
