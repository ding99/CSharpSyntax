
namespace cRegex {
	class Entrance {
		static void Main(string[] args) {

			tReg tr = new tReg();

			#region past
			//tr.rSpace();
			//tr.rComma();
			//tr.rFind1();
			//tr.rFind2();
			//tr.quotes();
			//tr.ends();
			//tr.rMatch();
			//tr.rMatchi();
			//tr.colorCode();
			//tr.spaces();
			//tr.num();
			//tr.searchccode();
			//tr.mediatime();

			//tr.exchAra();

			//tr.timecheck();
			//tr.decimalcheck();
			//tr.deccheck();
			//tr.perccheck();
			//tr.curencycheck();
			//tr.Omitcheck();
			//tr.Sepacheck();
			//tr.kmcheck();

			//tr.pac2();
			//tr.pac2();
			//tr.sch();
			//tr.rev();
			//tr.ens();
			//tr.brackets();
			//tr.gops();

			//tr.joins();
			//tr.mtest();
			//Cap p = new Cap();
			//p.redo();
			//tr.decItalics();
			//tr.rall();
			//tr.eall();
			#endregion

			#region past 2
			//tr.eighth();
			//tr.smiml();
			//tr.ovrml();

			//Cap c = new Cap();
			//c.chu();

			//MediaTime mt = new MediaTime();
			//mt.vttTests();
			#endregion

			Npv npv = new Npv();
			npv.slashes();

			Vtt v = new Vtt();
			v.lines();

			genRegex gen = new genRegex();
            gen.cmp();
            gen.align();
		}
	}
}
