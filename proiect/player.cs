using System.Collections.Generic;


namespace proiect
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }
        

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
        }

        public int HandValue()
        {
            int value = 0;
            int aceCount = 0;

            foreach (var card in Hand)
            {
                if (card.Rank == "ace")
                {
                    value += 11;
                    aceCount++;
                }
                else if (card.Rank == "queen" || card.Rank == "king" || card.Rank == "jack")
                {
                    value += 10;

                }
                else
                {
                    value += int.Parse(card.Rank);
                }
            }


            while (value > 21 && aceCount > 0)
            {
                value -= 10;
                aceCount--;
            }

            return value;
        }

    }
}
