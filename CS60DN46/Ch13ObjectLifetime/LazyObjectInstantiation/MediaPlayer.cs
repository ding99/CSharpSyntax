using System;

namespace LazyObjectInstantiation {
	class MediaPlayer {
		public void Play() { /* Play a song*/ Console.WriteLine("- Playback"); }
		public void Pause() { /*Pause the song */ Console.WriteLine("- Pause"); }
		public void Stop() { /* Stop playback */ Console.WriteLine("- Stop"); }
		private AllTracks allSongs = new AllTracks();

		public AllTracks GetAllTracks() {
			return allSongs;
		}
	}
}
