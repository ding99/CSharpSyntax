using System;

namespace LazyObjectInstantiation {
	class Program {
		static void Main() {
			Console.WriteLine("***** Lazy Object Instantiation *****");
			PlayBack();
			Console.ResetColor();
		}

		static void PlayBack() {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Playback a song");

			MediaPlayer player = new MediaPlayer();
			player.Play();
		}
	}
}
