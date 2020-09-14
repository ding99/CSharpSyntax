using System;

namespace LazyObjectInstantiation {
	class AllTracks {
		// The media player can have a max of 10000 songs
		private Song[] allSongs = new Song[10000];

		public AllTracks() {
			// Assume we fill up the array of Song objects here.
			allSongs[0] = new Song { Artist = "A", Trackname = "Song 001", TrackLength = 10 };
			allSongs[1] = new Song { Artist = "B", Trackname = "Song 002", TrackLength = 20 };
			Console.WriteLine("Filling up the songs!");
		}

		public void Choose(int n) { Console.WriteLine($"[{allSongs[n].Artist} / {allSongs[n].Trackname}]"); }
	}
}
