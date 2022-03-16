using System;
using System.Collections.Generic;
using System.Text;

namespace MediaPlayer
{
	public abstract class State {
    internal Player player;

    public State(Player player) {
        this.player = player;
    }

    public abstract string Lock();
    public abstract string Play();
    public abstract string Next();
    public abstract string Previous();
}
}
