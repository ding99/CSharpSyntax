using System;
using System.Text;

namespace cStrings {
	public class chkSpace{
		public chkSpace(){}

		#region arrow
		private void one(string s){

			byte[] srcByte = Encoding.GetEncoding("iso-8859-1").GetBytes(s);
			string m = string.Empty;
			foreach(byte b in srcByte)
				m += (m.Length > 0 ? " " : "") + b.ToString("x2");

			Console.WriteLine("[" + m + "]  Space (" + string.IsNullOrWhiteSpace(s) + ")");
		}

		public void spaces(){
			one(" ");
			one(" " + "\t");
			one(" " + '\u00a0');
			one(" " + '\u3000');
		}

        public void trims() {
            string str0 = "zzz";
            string str1 = $"aaa bbb ";
            string str2 = str1.TrimEnd();
            string str3 = $"ccc ddd ".TrimEnd();
            string str5 = $"eee {(str0.Length > 3 ? str0 : "")}".TrimEnd();
            string str6 = $"fff {(str0.Length > 2 ? str0 : "")}".TrimEnd();

            Console.WriteLine($"1-[{str1}] 2-[{str2}] 3-[{str3}] 5-[{str5}] 6-[{str6}]");
        }
		#endregion

	}
}
