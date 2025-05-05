using System;
using System.Collections.Generic;
using System.IO;


namespace proiect
{
    public class Deck
    {

        private List<Card> cards;

        public Deck()
        {
            cards = new List<Card>();
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            string[] suits = { "hearts", "diamonds", "clubs", "spades" };
            string[] ranks = { "ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king" };

           

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {  
                    cards.Add(new Card(rank, suit));
                }
            }
        }

        public List<Card> GetAllCards()
        {
            return cards;
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;

            for (int i = n - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                var tempCard = cards[i];
                cards[i] = cards[j];
                cards[j] = tempCard;
            }
        }

    }

}
