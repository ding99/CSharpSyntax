using CommonLogs;
using System;
using System.IO;
using System.Text;

namespace CStrings
{
	public class Encoder
	{
		private CommonLog re;

		public Encoder()
		{
			this.re = new CommonLog(@"D:\workFolder\General\enc.log", "enc");
			this.re.log("-- Start");
		}


		private void pbuf(byte[] b, string s)
		{
			this.re.log("=== " + s + " : buffer size " + b.Length);
			string m = String.Empty;
			for(int i = 0; i < b.Length; i++)
				m += b[i].ToString("x2") + (i + 1 == b.Length ? "" : "");
			this.re.log(m);
		}

		public bool Encodes()
		{
			CommonLog re = new CommonLog("enc");

			Encoding asc = Encoding.GetEncoding("iso-8859-1");
			Encoding uni = Encoding.Unicode;

			byte[] srcByte = new byte[1];
			srcByte[0] = 0x9c;
			this.pbuf(srcByte, "ascii");

			char[] srcChar = new char[asc.GetCharCount(srcByte, 0, srcByte.Length)];
			asc.GetChars(srcByte, 0, srcByte.Length, srcChar, 0);
			string srcString = new string(srcChar);

			this.re.log(srcString);

			byte[] tarByte = Encoding.Convert(Encoding.GetEncoding("iso-8859-1"), Encoding.Unicode, srcByte);
			this.pbuf(tarByte, "unicode");

			char[] tarChar = new char[asc.GetCharCount(srcByte, 0, srcByte.Length)];
			uni.GetChars(tarByte, 0, tarByte.Length, tarChar, 0);
			string tarString = new string(tarChar);

			this.re.log(tarString);

			byte[] reByte = uni.GetBytes(tarString.ToLower());
			this.pbuf(reByte, "re");

			byte[] sv = new byte[0];

			using(MemoryStream ms = new MemoryStream())
			{
				using(StreamWriter sw = new StreamWriter(ms, Encoding.Unicode))
					sw.Write(tarString);
				sv = ms.ToArray();
			}

			this.pbuf(sv, "save");
			return true;
		}
	}
}
