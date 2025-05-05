namespace proiect
{   
    public class Dealer : Player
    {
        public Dealer() : base("Dealer") { }
        public void PlayTurn(Deck deck)
        {
            while (HandValue() < 17)
            {
                Card card = deck.GetAllCards()[0];
                deck.GetAllCards().RemoveAt(0);
                AddCard(card);
               
            }
        }
    }
}
