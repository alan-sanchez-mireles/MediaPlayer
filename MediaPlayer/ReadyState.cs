using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
	public class ReadyState : State
	{
		public ReadyState(Player player) :
			base(player)
		{ }
		public override string Lock()
		{
			player.State = new LockedState(player);
			return "Locked...";
		}

		public override string Play()
		{
			String action = player.StartPlayback();
			player.State = new PlayingState(player);
			return action;
		}

		public override string Next()
		{
			return "Locked...";
		}
		public override string Previous()
		{
			return "Locked...";
		}
	}
}