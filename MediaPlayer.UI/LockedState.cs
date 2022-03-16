using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.UI
{
	public class LockedState : State
	{
		public LockedState(Player player) :
			base(player)
		{ 
			player.IsPlaying = false;
			StateName = "Locked";
		}
		public override string Lock()
		{
			if(player.IsPlaying)
			{
				player.State = new ReadyState(player);
				return "Stop playing";
			}
			else
			{
				return "Locked...";
			}
		}
		public override string Play()
		{
			player.State = new ReadyState(player);
			return "Ready";
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
