using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer.UI
{
	public abstract class State {
    internal Player player;

    public State(Player player) {
        this.player = player;
    }

	public string StateName { get; internal set; }

	public abstract string Lock();
    public abstract string Play();
    public abstract string Next();
    public abstract string Previous();
}
}
