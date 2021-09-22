using System;
using System.ComponentModel;

namespace CEnum {
	public static class Utilities {
		public static T GetDefaultValue<T>() where T: struct, Enum {
			Type t = typeof(T);
			DefaultValueAttribute[] attributes = (DefaultValueAttribute[])t.GetCustomAttributes(typeof(DefaultValueAttribute), false);

			if (attributes != null && attributes.Length > 0)
				return (T)attributes[0].Value;
			else
				return default(T);
		}
	}

	public class Default {

		enum CapMode {
			Subtitle = 0,
			CEA_608 = 1,
			Teletext = 2,
			Custom = 99,
			Default = Subtitle
		}

		public Default() {
			Console.ForegroundColor = ConsoleColor.Blue;
		}

		public void List() {
			Console.WriteLine("< Same values in an enum >");
			Console.Write("Names :");
			foreach(var c in Enum.GetNames(typeof(CapMode)))
				Console.Write($" [{c}]");
			Console.WriteLine();
			Console.Write("Values:");
			foreach (var c in Enum.GetValues(typeof(CapMode)))
				Console.Write($" [{(int)c}]");
			Console.WriteLine();
		}

		enum A { Foo, Bar, Baz, Quux }
		enum B { Foo = -1, Bar, Baz, Quux }
		enum C { Foo = 1, Bar = 2, Baz = 3, Quux = 0 }
		enum D { Foo = 1, Bar = 2, Baz = 3, Quux = 4 }

		[DefaultValue(Baz)]
		public enum E { Foo = 1, Bar = 2, Baz = 3, Quux = 4 }

		enum F { Foo = 1, Bar = 2, Baz = 3, Default = Bar }

		private void Dsp(Enum e) {
			Console.Write("names:");
			foreach (var i in Enum.GetNames(e.GetType()))
				Console.Write($" {i}");
			Console.Write("; values:");
			foreach (var i in Enum.GetValues(e.GetType()))
				Console.Write($" {i}[{(int)i}]");
			Console.WriteLine($". default: {e}[{Convert.ToInt32(e)}]");
		}

		public void Defaults() {
			Console.WriteLine("< Show Default >");
			Dsp(default(A));
			Dsp(default(B));
			Dsp(default(C));
			Dsp(default(D));
			Dsp(default(E));
			Dsp(default(F));
			Console.WriteLine("<TODO>: how to define what a default is");

			Dsp(Utilities.GetDefaultValue<A>());
			Dsp(Utilities.GetDefaultValue<B>());
			Dsp(Utilities.GetDefaultValue<C>());
			Dsp(Utilities.GetDefaultValue<D>());
			Dsp(Utilities.GetDefaultValue<E>());
			Dsp(Utilities.GetDefaultValue<F>());
		}
	}
}
