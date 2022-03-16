using System;

namespace MediaPlayer
{
	class Program
	{
		static void Main(string[] args)
		{
			Player player = new Player();

			Console.WriteLine(player.NextTrack());

			Console.WriteLine(player.NextTrack());
		}
	}
}
