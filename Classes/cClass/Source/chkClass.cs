using System;
using System.Collections.Generic;

namespace cClass {

	public class cData {
		public string cStr;
		public int cDec;
		public bool cFlag;

		public cData() {
			this.cStr = String.Empty;
			this.cDec = 0;
			this.cFlag = false;
		}
	}

	public class aData {
		public string cStr { get; set; }
		public int cDec { get; set; }
		public bool cFlag { get; set; }
	}

	public class chkClass {
		public chkClass() {
		}

		public void className() {
			cData cd = new cData() { cStr = "Student", cDec = 50, cFlag = true };
			Console.WriteLine("First [" + cd.cStr + "," + cd.cDec + "," + cd.cFlag + "]");

			Type cls = typeof(cData);
			Console.WriteLine("  name      [" + cls.Name + "]");
			Console.WriteLine("  namespace [" + cls.Namespace + "]");
			Console.WriteLine("  full      [" + cls.ToString() + "]");

		}

		public void classMember() {
			cData cd = new cData() { cStr = "Student", cDec = 50, cFlag = true };
			Console.WriteLine("First [" + cd.cStr + "," + cd.cDec + "," + cd.cFlag + "]");

			foreach(System.Reflection.FieldInfo f in typeof(cData).GetFields())
				Console.WriteLine(f.Name + ", " );
		}

		public void initClass() {
			Console.WriteLine("--- cData ---");
			cData c1 = new cData() { cDec = 5 };
			cData c2 = new cData { cDec = 5 };
			Console.WriteLine("c1: (" + c1.cStr + ", " + c1.cDec + ", " + c1.cFlag + ")");
			Console.WriteLine("c2: (" + c2.cStr + ", " + c2.cDec + ", " + c2.cFlag + ")");

			Console.WriteLine("--- aData ---");
			aData a1 = new aData() { cDec = 5 };
			aData a2 = new aData { cDec = 5 };
			Console.WriteLine("a1: (" + a1.cStr + ", " + a1.cDec + ", " + a1.cFlag + ")");
			Console.WriteLine("a2: (" + a2.cStr + ", " + a2.cDec + ", " + a2.cFlag + ")");
		}
	}

	class CFrame : System.Object {
		public double rate;
		public bool drop;
		public bool valid;

		//public CFrame() {
		//    this.rate = 0;
		//    this.drop = false;
		//    this.valid = false;
		//}

		public CFrame(double r, bool d, bool v){
			this.rate = r;
			this.drop = d;
			this.valid = v;
		}

		public override bool Equals(System.Object obj){
			if(obj == null) return false;
			CFrame c = obj as CFrame;
			if((System.Object)c == null) return false;
			return rate == c.rate && drop == c.drop && valid == c.valid;
		}
		//public override bool Equals(CFrame c) {
		//    if((object)c == null) return false;
		//    return rate == c.rate && drop == c.drop && valid == c.valid;
		//}
		public override int GetHashCode() {
			return 0;
		}
		public static bool operator ==(CFrame a, CFrame b) {
			if(System.Object.ReferenceEquals(a, b))
				return true;
			if(((object)a == null) || ((object)b == null))
				return false;
			return a.rate == b.rate && a.drop == b.drop && a.valid == b.valid;
		}
		public static bool operator !=(CFrame a, CFrame b) {
			return !(a == b);
		}
	}

	class DFrame {
		public double rate;
		public bool drop;
		public bool valid;

		public DFrame(double r, bool d, bool v) {
			this.rate = r;
			this.drop = d;
			this.valid = v;
		}
	}

	public class tCmp {
		public tCmp() {
		}

		private void dsp(CFrame f, string m) {
			Console.WriteLine(m + " [" + f.rate + ", " + f.drop + ", " + f.valid + "]");
		}

		public void toCmp() {
			CFrame c1 = new CFrame(23.976, false, true);
			CFrame c2 = new CFrame(29.97, true, true);

			this.dsp(c1, "C1");
			this.dsp(c2, "C2");
			Console.WriteLine("equal [" + (c1 == c2) + "]");
			Console.WriteLine("------");

			c2.rate = c1.rate;
			c2.drop = c1.drop;
			c2.valid = c1.valid;

			this.dsp(c1, "C1");
			this.dsp(c2, "C2");
			Console.WriteLine("equal [" + (c1 == c2) + "]");
			Console.WriteLine("------");

			c2 = new CFrame(29.97, true, true);

			this.dsp(c1, "C1");
			this.dsp(c2, "C2");
			Console.WriteLine("------");
		}

		public void declaration() {
			int? dff = null;

			Console.WriteLine("valid [" + dff.HasValue + "]");
			dff = 2;
			Console.WriteLine("valid [" + dff.HasValue + "]");
			if(dff.HasValue)
				Console.WriteLine("  dff value[" + dff + "]");

			Console.WriteLine();

			DFrame f = null;
			Console.WriteLine("f is " + (f == null ? "" : "non " ) + "empty");

			f = new DFrame(29.97, true, true);
			Console.WriteLine("f is " + (f == null ? "" : "non ") + "empty");
			if(f != null)
				Console.WriteLine("  " + f.rate + ", " + f.drop + ", " + f.valid);
		}
	}

	#region loop
	public class GFile {
		public string name;
		public long loca;
		public long size;

		public GFile() {
			this.name = String.Empty;
			this.loca = 0;
			this.size = 0;
		}
	}

	public class GDir {
		public string name;
		public List<GDir> dirs;
		public List<GFile> files;

		public GDir() {
			this.name = String.Empty;
			this.dirs = new List<GDir>();
			this.files = new List<GFile>();
		}
	}

	public class GTree {
		public string root;
		public GDir entry;

		private int seekFile(string name, List<GFile> files) {
			for(int i = 0; i < files.Count; i++)
				if(files[i].name == name) return i;
			return -1;
		}
		private void moveFile(string name, List<GFile> src, List<GFile> dst) {
			int n = this.seekFile(name, src);
			if(n >= 0) {
				dst.Add(src[n]);
				src.RemoveAt(n);
			}
		}
		private int seekDir(string name, List<GDir> dirs) {
			for(int i = 0; i < dirs.Count; i++)
				if(dirs[i].name == name) return i;
			return -1;
		}

		public GTree() {
			this.root = String.Empty;
			this.entry = new GDir();
		}
		public void reOrder() {

			int dn = this.seekDir("VIDEO_TS", this.entry.dirs);

			if(dn < 0) return;

			#region files
			List<GFile> sfs = this.entry.dirs[dn].files;
			List<GFile> dfs = new List<GFile>();

			string bs = "VIDEO_TS.";
			this.moveFile(bs + "IFO", sfs, dfs);
			this.moveFile(bs + "VOB", sfs, dfs);
			this.moveFile(bs + "BUP", sfs, dfs);

			for(int i = 1; i < 100; i++) {
				this.moveFile((bs = "VTS_") + i.ToString("D2") + "_0.IFO", sfs, dfs);
				this.moveFile(bs + i.ToString("D2") + "_0.VOB", sfs, dfs);
				bs += i.ToString("D2") + "_";
				for(int j = 1; j < 10; j++)
					this.moveFile(bs + j.ToString() + ".VOB", sfs, dfs);
				this.moveFile("VTS_" + i.ToString("D2") + "_0.BUP", sfs, dfs);
			}

			foreach(GFile f in sfs)
				dfs.Add(f);

			this.entry.dirs[dn].files = dfs;
			#endregion

			#region dirs
			List<GDir> ss = this.entry.dirs;
			List<GDir> ds = new List<GDir> { ss[dn] };
			ss.RemoveAt(dn);

			foreach(GDir d in ss)
				ds.Add(d);

			this.entry.dirs = ds;
			#endregion
		}

		private void dsp(GDir d){
			Console.WriteLine(d.name);
			foreach(GFile f in d.files)
				Console.WriteLine("  " + f.name + " " + f.loca + " / " + f.size);
			if(d.dirs.Count > 0)
				foreach(GDir f in d.dirs)
					this.dsp(f);
		}

		public void multit(){
			List<GFile> f_sub01 = new List<GFile>{
				new GFile{ name="S01001", loca = 1, size = 10},
				new GFile{ name="S01002", loca = 2, size = 20}
			};

			List<GFile> f_sub02 = new List<GFile>{
				new GFile{ name="S02001", loca = 1, size = 10},
				new GFile{ name="S02002", loca = 2, size = 20}
			};

			List<GFile> f_sub10 = new List<GFile>{
				new GFile{ name="F02001", loca = 1, size = 10},
				new GFile{ name="F02002", loca = 2, size = 20}
			};

			List<GDir> d_sub01 = new List<GDir>{
				new GDir{ name = "D001", files = f_sub01 },
				new GDir{ name = "D002", files = f_sub02 }
			};

			GDir P100 = new GDir{ name="top", dirs=d_sub01, files = f_sub10};

			Console.WriteLine(P100.name);
			this.dsp(P100);
		}
	}
	#endregion
}
