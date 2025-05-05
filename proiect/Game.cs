using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proiect
{
    public partial class Game : Form
    {
        private Dealer dealer;
        private Deck deck;
        private Player player;
        private bool PlayerTurn = true;
        private int playerWins = 0;
        private int dealerWins = 0;

        public Game()
        {
            InitializeComponent();
            InitializeGame();

        }
        public void InitializeGame()
        {
            List<Control> controlsToRemove = new List<Control>();

            foreach (Control control in Controls)
            {
                if (control is PictureBox)
                {
                    controlsToRemove.Add(control);
                }
            }

            foreach (Control control in controlsToRemove)
            {
                Controls.Remove(control);
                control.Dispose();
            }

            player = new Player("Player");
            dealer = new Dealer();
            deck = new Deck();
            deck.Shuffle();
            PlayerTurn = true;

            btnPlayAgain.Visible = false;

            for (int i = 0; i < 2; i++)
            {
                Card card = deck.GetAllCards()[0];
                deck.GetAllCards().RemoveAt(0);
                player.AddCard(card);
                AddCardToUI(card, "Player");
            }
            for (int i = 0; i < 2; i++)
            {
                Card card2 = deck.GetAllCards()[0];
                deck.GetAllCards().RemoveAt(0);
                dealer.AddCard(card2);
                AddCardToUI(card2, "Dealer");
            }

            UpdateGameUI();

        }


        public void AddCardToUI(Card card, string owner)
        {

            PictureBox cardPictureBox = new PictureBox
            {
                Image = card.Image,
                Size = new Size(80, 120),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            if (owner == "Player")
            {
                cardPictureBox.Location = new Point(70 + player.Hand.Count * 90, 400);
            }
            else if (owner == "Dealer")
            {
                cardPictureBox.Location = new Point(70 + dealer.Hand.Count * 90, 100);
            }

            Controls.Add(cardPictureBox);
        }
        private void UpdateGameUI()
        {
            lblPlayerSum.Text = $"Player's Sum: {player.HandValue()}";
            lblDealerSum.Text = $"Dealer's Sum: {dealer.HandValue()}";
        }

        private void DetermineWinner()
        {
            int playerSum = player.HandValue();
            int dealerSum = dealer.HandValue();

            string result;
            if (playerSum > 21)
            {
                result = "Player busted! Dealer wins!";
                dealerWins++;
            }
            else if (dealerSum > 21)
            {
                result = "Dealer busted! Player wins!";
                playerWins++;
            }
            else if (playerSum > dealerSum)
            {
                result = "Player wins!";
                playerWins++;
            }
            else if (playerSum < dealerSum)
            {
                result = "Dealer wins!";
                dealerWins++;
            }
            else
            {
                result = "It's a tie!";
            }

            MessageBox.Show($"{result}\n\nScore:\nPlayer: {playerWins}\nDealer: {dealerWins}", "Game Over");

            btnPlayAgain.Visible = true;
        }
        private void UpdatePlayerSum(Player player)
        {
            int playerSum = player.HandValue();
            lblPlayerSum.Text = $"Player's Sum: {playerSum}";
        }

        private void UpdateDealerSum(Dealer dealer)
        {
            int dealerSum = dealer.HandValue();
            lblDealerSum.Text = $"Dealer's Sum: {dealerSum}";
        }
        private void btnHit_Click(object sender, EventArgs e)
        {
            if (PlayerTurn)
            {
                Card card = deck.GetAllCards()[0];
                deck.GetAllCards().RemoveAt(0);
                player.AddCard(card);
                AddCardToUI(card, "Player");
                UpdatePlayerSum(player);
                if (player.HandValue() > 21)
                {
                    DetermineWinner();
                }
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            if (PlayerTurn)
            {
                PlayerTurn = false;
                while (dealer.HandValue() < 17)
                {
                    Card card = deck.GetAllCards()[0];
                    deck.GetAllCards().RemoveAt(0);
                    dealer.AddCard(card);
                    AddCardToUI(card, "Dealer");
                    UpdateDealerSum(dealer);
                }
                DetermineWinner();

            }


        }
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

    }
}