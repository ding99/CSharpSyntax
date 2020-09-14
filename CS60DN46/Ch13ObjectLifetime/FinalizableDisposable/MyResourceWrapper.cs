using System;

namespace FinalizableDisposable {
	class MyResourceWrapper : IDisposable {
		//determine if Dispose() called
		private bool disposed = false;

		// The object user will call this method to clean up
		// resource ASAP
		public void Dispose() {
			// Call our helper method.
			// Specifying "true" signifies that
			// the object user triggered the cleanup
			CleanUp(true);

			// Now suppress finalization
			GC.SuppressFinalize(this);
			Console.WriteLine("----- In Dispose! -----");
		}

		private void CleanUp(bool disposing) {
			// Be sure we have not slready been disposed
			if (!this.disposed) {
				// If disposing equals true, dispose all managed resources
				if (disposing) {
					// Dispose managed resources
				}
				// Clean up unmanaged resources here.
			}
			disposed = true;
		}

		//The garbage collector will call this method if the
		// object user forgets to call Dispose().
		~MyResourceWrapper() {
			Console.Beep(); // to test
							// Call our helper method.
							// Specifying "false" signigies that
							// the GC triggered the cleanup
			CleanUp(false);
			Console.WriteLine("----- In Destructor! -----");
		}
	}
}
