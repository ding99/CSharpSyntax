using System;

namespace LazyObjectInstantiation {
	class AllTracks {
		// The media player can have a max of 10000 songs
		private Song[] allSongs = new Song[10000];

		public AllTracks() {
			// Assume we fill up the array of Song objects here.
			Console.WriteLine("Filling up the songs!");
		}
	}
}
