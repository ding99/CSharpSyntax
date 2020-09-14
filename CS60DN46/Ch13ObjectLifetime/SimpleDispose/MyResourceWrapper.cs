using System;

namespace SimpleDispose {
	class MyResourceWrapper : IDisposable {
		// The object user should call this method
		// when they finish with the object.
		public void Dispose() {
			// Clean up unmanaged resources here

			// Dispose ther contained disposable objects...
			Console.WriteLine("----- In Dispose! -----");
		}
	}
}
