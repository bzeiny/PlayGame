using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //allows the use of thread.sleep()
using System.Media; //allows the use of soundplayer

namespace PlayGame
{
    public partial class PlayGameLabel : Form
    {
        public PlayGameLabel()
        {
            InitializeComponent();
        }

        private void PlayGame_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameLabel.Visible = false;
            StartButtonLabel.Visible = false;
            //create a sound player and load the alert.wav sound, then play it 

            SoundPlayer alertPlayer = new SoundPlayer(Properties.Resources.mixkit_simple_game_countdown_921);
            //Begin countdown starting from 3, going until 1 then vanishing
            alertPlayer.Play();
            CountdownLabel3.Text = "Begin in 3...";
            Refresh();
            Thread.Sleep(1000);

            CountdownLabel3.Text = "Begin in 2...";
            Refresh();
            Thread.Sleep(1000);

            CountdownLabel3.Text = "Begin in 1...";
            Refresh();
            Thread.Sleep(1000);
            //Change the sound from countdown to a gamesound loop, changing the background colour and displaying the "Go" text
            SoundPlayer safariPlayer = new SoundPlayer(Properties.Resources.African_Safari_Loop);
            safariPlayer.Play();
            CountdownLabel3.Text = "";
            GoLabel.Text = "GOOOO!!!";
            this.BackColor = Color.Green;

            GameLabel.ForeColor = Color.Purple;
        }

        private void CountdownLabel3_Click(object sender, EventArgs e)
        {

        }

        private void GoLabel_TextChanged(object sender, EventArgs e)
        {

        }

        private void GoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
