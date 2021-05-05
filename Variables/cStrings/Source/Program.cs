using cStrings;
using System;

namespace CStrings {
	class Entrance {

		static void Main(string[] args) {

			Console.WriteLine("=== start");

            bool ret = false;

			#region past
			//TestString ts = new TestString();
			//ret = ts.timeFormat();
			//ret = ts.replace();
			//ret = ts.parastring();
			//ret = ts.parseInt();
			//ret = ts.subone();
			//ret = ts.italic();
			//ret = ts.dspTime();
			//ret = ts.lastindex();
			//ret = ts.linuxPath();
			//ret = ts.digits();
			//ret = ts.tsub();
			//ret = ts.hex2bytes();
			//ret = ts.bytes2hex();
			//ret = ts.newline();
			//ret = ts.crs();
			//ret = ts.UnicodeBuf();
			//ret= ts.subDigit();
			//ret = ts.fullhalf();
			//ts.arrows();
			//ts.uppcheck();

			//ret = ts.splits();
			//ret = ts.indx();
			//ret = ts.parseUtf();

			//ret = ts.geneUtf();
			//ret = ts.chinint();
			//ret = ts.startw();
			#endregion

			#region color
			//TestColor tc = new TestColor();
			//ret = tc.colorid();
			#endregion

			#region encode
			//Encoder en = new Encoder();
			//ret = en.Encodes();
			#endregion

			#region char
			//TestChar cchar = new TestChar();
			//cchar.chars();
			//cchar.clses();
			//cchar.spcc();
			//cchar.quavers();
			#endregion

			#region parse
			//TestParse tp = new TestParse();
			//tp.parseHex();
			//tp.idex();
			//tp.tryparse();
			#endregion

			#region JP
			//TestJP jp = new TestJP();
			//jp.chkChar();
			#endregion

			#region PAC
			//TestPAC pac = new TestPAC();
			//pac.chkChar();
			#endregion

			#region space
			//ChkSpace space = new ChkSpace();
			//space.trims();
			//space.spaces();
			#endregion

			#region stringbuilder
			CStringbuilder bd = new CStringbuilder();
			bd.cap();
			bd.prm();
			bd.jon();
			#endregion

			#region foramt brakets
			//Bracket b = new Bracket();
			//b.test();
			#endregion

			#region trim
			//CheckTrim trims = new CheckTrim();
			//trims.checks();
			#endregion

			#region types
			//Types types = new Types();
			//types.ExamingTypes();
			#endregion

			#region qualified
			Evaluation e = new Evaluation();
			e.ExamineOrder();
			e.ExamineBase64();
			e.ExamineChars();
			#endregion

			#region compare
			Equaling cmp = new Equaling();
			cmp.CompareString();
			cmp.CompareClass();
			#endregion

			Console.ResetColor();
            Console.WriteLine("=== end");
		}

	}
}
