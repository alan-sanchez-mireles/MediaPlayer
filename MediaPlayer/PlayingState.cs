using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
	public class PlayingState : State
	{

		public PlayingState(Player player) :
				base(player)
		{ }
		public override string Lock()
		{
			player.State = new LockedState(player);
			player.SetCurrentTrackAfterStop();
			return "Stop playing";
		}

		public override string Play()
		{
			player.State = new ReadyState(player);
			return "Paused...";
		}

		public override string Next()
		{
			return player.NextTrack();
		}
		public override string Previous()
		{
			return player.PreviousTrack();
		}
	}
}
