using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ObjectContextApp {

	[Synchronization]
	class SportsCarTS : ContextBoundObject {
		public SportsCarTS() {
			Context ctx = Thread.CurrentContext;
			Console.WriteLine($"{this.ToString()} object in context {ctx.ContextID}");
			foreach (IContextProperty p in ctx.ContextProperties)
				Console.WriteLine($"   Ctx Prop: {p.Name}");
		}
	}
}
