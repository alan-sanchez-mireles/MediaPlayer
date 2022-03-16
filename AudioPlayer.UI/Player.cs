using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.UI
{
	//Context
	public class Player
	{
		private List<string> playlist = new List<string>();
		private int currentTrack = 0;

		public Player()
		{
			State = new ReadyState(this);
			IsPlaying = true;
			for(int i = 1; i <= 5; i++)
			{
				playlist.Add($"Track {i}");
			}
		}

		public State State { get; set; }
		public bool IsPlaying { get; set; }

		public string StartPlayback()
		{
			return $"Playing {playlist[currentTrack]}";
		}
		public string NextTrack()
		{
			currentTrack++;
			if(currentTrack > playlist.Count - 1)
			{
				currentTrack = 0;
			}
			return $"Playing {playlist[currentTrack]}";
		}
		public string PreviousTrack()
		{
			currentTrack--;
			if(currentTrack < 0)
			{
				currentTrack = playlist.Count - 1;
			}
			return $"Playing {playlist[currentTrack]}";
		}

		public void SetCurrentTrackAfterStop()
		{
			this.currentTrack = 0;
		}
	}
}
