using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSerialize {

	[Serializable]
	//[DataContract(Namespace = "http://DL3/Rendering/rv01")]
	public class ClassOrg {
		//[DataMember]
		public string name;
		//[DataMember]
		public int age;
		//[DataMember]
		public bool work;

		//public ClassOrg(){
		//    this.name = String.Empty;
		//    this.age = 0;
		//    this.work = true;
		//}
	}

	[Serializable]
	//[DataContract(Namespace = "http://DL3/Rendering/rv01")]
	public class ClassCpy {
		//[DataMember]
		public string name;
		//[DataMember]
		public int age;
		//[DataMember]
		public bool work;

		//public ClassCpy(){
		//    this.name = String.Empty;
		//    this.age = 0;
		//    this.work = true;
		//}
	}

	public class SDS {
		public SDS(){
			Console.ForegroundColor = ConsoleColor.Cyan;
		}

		public byte[] BSerialize<T>(T cc) {
			MemoryStream ms = new MemoryStream();

			try {
				new BinaryFormatter().Serialize(ms, cc);
				return ms.ToArray();
			} catch(Exception e) {
				Console.WriteLine("** VSerialize [" + e.Message + "]");
				return new byte[0];
			} finally {
				ms.Close();
			}
		}
		public T BDeSerialize<T>(byte[] stream) {
			MemoryStream ms = new MemoryStream();

			try {
				ms.Write(stream, 0, stream.Length);
				ms.Seek(0L, SeekOrigin.Begin);
				return (T)(new BinaryFormatter().Deserialize(ms));
			} catch(Exception e){
				Console.WriteLine("** DBeSerialize [" + e.Message + "]");
				return default(T);
			} finally {
				ms.Close();
			}
		}

		public string Serialize<T>(T ob) {
			BinaryFormatter bf = new BinaryFormatter();
			MemoryStream ms = new MemoryStream();

			try {
				bf.Serialize(ms, ob);
				ms.Position = 0;
				return Convert.ToBase64String(ms.ToArray());
			} catch(Exception e) {
				Console.WriteLine("** SSerialize [" + e.Message + "]");
				return String.Empty;
			} finally {
				ms.Close();
			}
		}
		public T DeSerialize<T>(string s) {
			BinaryFormatter bf = new BinaryFormatter();
			byte[] b = Convert.FromBase64String(s);
			MemoryStream ms = new MemoryStream(b);

			try {
				return (T)bf.Deserialize(ms);
			} catch(Exception e) {
				Console.WriteLine("** SDeSerialize [" + e.Message + "]");
				return default(T);
			} finally {
				ms.Close();
			}
		}

		public bool binaryT() {
			Console.WriteLine("-- Binary Test");

			ClassOrg co = new ClassOrg();
			co.name = "JohnB";
			co.age = 26;
			co.work = true;

			byte[] sets = this.BSerialize<ClassOrg>(co);
			Console.WriteLine("binary size [" + sets.Length + "]");

			try {
				ClassOrg od = this.BDeSerialize<ClassOrg>(sets);
				Console.WriteLine("  org name [" + od.name + "]");

				ClassCpy cd = this.BDeSerialize<ClassCpy>(sets);
				Console.WriteLine("  cpy name [" + cd.name + "]");
			} catch(Exception e) {
				Console.WriteLine("Org 2 Cpy [" + e.Message + "]");
				return false;
			}

			return true;
		}

		public bool stringT() {
			Console.WriteLine("-- String Test");

			ClassOrg co = new ClassOrg();
			co.name = "JohnT";
			co.age = 26;
			co.work = true;

			string sets = this.Serialize<ClassOrg>(co);
			Console.WriteLine("string size [" + sets.Length + "]");

			try {
				ClassOrg od = this.DeSerialize<ClassOrg>(sets);
				Console.WriteLine("  org name [" + od.name + "]");

				ClassCpy cd = this.DeSerialize<ClassCpy>(sets);
				Console.WriteLine("  cpy name [" + cd.name + "]");
			} catch(Exception e) {
				Console.WriteLine("Org 2 Cpy [" + e.Message + "]");
				return false;
			}

			return true;
		}
	}
}
