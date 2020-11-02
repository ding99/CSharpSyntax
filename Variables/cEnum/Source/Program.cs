using System;

namespace CEnum {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("==  start");

			(new EnumParse()).parse();
			(new EnumShow()).stt();
			(new Enum2String()).transf();
			(new EnumSearch()).search();

			Comma cm = new Comma();
			cm.comp();
			cm.ecopy();
			cm.inv();
			cm.seeDigit();

			Compare cmp = new Compare();
			cmp.start();
			cmp.greater();

            Console.WriteLine("==  end");
        }
    }

}
