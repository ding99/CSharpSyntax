using System;

namespace LazyObjectInstantiation {
	class MediaPlayer {
		public void Play() { /* Play a song*/ Console.WriteLine("- Playback"); }
		public void Pause() { /*Pause the song */ Console.WriteLine("- Pause"); }
		public void Stop() { /* Stop playback */ Console.WriteLine("- Stop"); }

		private Lazy<AllTracks> allSongs = new Lazy<AllTracks>(() => {
			Console.WriteLine("Creating AllTracks object!");
			return new AllTracks();
		});

		public AllTracks GetAllTracks() {
			Console.WriteLine("- Get All Tracks");
			return allSongs?.Value;
		}
	}
}
