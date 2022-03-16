using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.UI
{
	public partial class Form1 : Form
	{
	    Player player; 
		public Form1()
		{
			InitializeComponent();
			player = new Player();
			lblState.Text = player.State.StateName;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			lblStatus.Text = player.State.Next();
			lblState.Text = player.State.StateName;
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			lblStatus.Text = player.State.Play();
			lblState.Text = player.State.StateName;
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			lblStatus.Text = player.State.Lock();
			lblState.Text = player.State.StateName;
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			lblStatus.Text = player.State.Previous();
			lblState.Text = player.State.StateName;
		}
	}
}
