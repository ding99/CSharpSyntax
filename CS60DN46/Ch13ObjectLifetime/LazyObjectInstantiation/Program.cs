using System;

namespace LazyObjectInstantiation {
	class Program {
		static void Main() {
			Console.WriteLine("***** Lazy Object Instantiation *****");
			UseLazyObject();
			Console.ResetColor();
		}

		static void UseLazyObject() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Playback a song");

			MediaPlayer player = new MediaPlayer();
			player.Play();

			MediaPlayer yourPlayer = new MediaPlayer();
			AllTracks yourMusic = yourPlayer.GetAllTracks();
			if (yourMusic == null)
				Console.WriteLine("GetAllTracks() return null");
			else {
				Console.WriteLine($"Songs size <{yourMusic.Size()}>");
				yourMusic.Choose(0);
				yourMusic.Choose(1);
			}
		}
	}
}
