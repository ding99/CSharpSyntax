using System;

namespace CEnum {
    class Program {
        static void Main() {
            Console.WriteLine("==  start");

			(new EnumParse()).parse();
			(new EnumShow()).stt();
			(new Enum2String()).transf();
			(new EnumSearch()).Parse();

			Comma cm = new Comma();
			cm.comp();
			cm.ecopy();
			cm.inv();
			cm.seeDigit();

			Compare cmp = new Compare();
			cmp.start();
			cmp.greater();

			Default def = new Default();
			def.List();

			Console.ResetColor();
            Console.WriteLine("==  end");
        }
    }

}
