using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp {
	class SportsCar {
		public SportsCar() {
			Context ctx = Thread.CurrentContext;
			Console.WriteLine($"{this.ToString()} object in context {ctx.ContextID}");
			foreach(IContextProperty p in ctx.ContextProperties)
				Console.WriteLine($"-> Ctx Prop: {p.Name}");
		}
	}
}

