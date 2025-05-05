using System;
using System.Windows.Forms;

namespace proiect
{
    public partial class Game_Menu : Form
    {
        public Game_Menu()
        {
            InitializeComponent();
        }

        private void btnHop_Click(object sender, EventArgs e)
        {
            How_to_play popup = new How_to_play("I'll teach you how to play Blackjack.");
            popup.ShowDialog();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            Rules popup2 = new Rules("Here are the main rules of Blackjack. ");
            popup2.ShowDialog();
        }
    }
}
