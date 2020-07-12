using System;

namespace cEnvironment {

    class Entrance {
        static void Main(string[] args) {

            Console.WriteLine("== Start");

            Env env = new Env();
            //env.encVari();
            //env.display();
            env.seten();

            Console.WriteLine("== End");
        }
    }
}
