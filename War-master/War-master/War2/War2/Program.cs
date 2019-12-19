using System;

namespace War2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public enum Suit
        {
            Diamonds,
            Spades,
            Hearts,
            Clubs
        }
        public class Card
        {
            public string DisplayName { get; set; }
            public Suit Suit { get; set; }
            public int Value { get; set; }
        }
        public class Player
        {
            public string Name { get; set; }
            public Queue<Card> Deck { get; set; }
        }
        public static class Extensions
        {
            public static void Enqueue(this Queue<Card> cards, Queue<Card> newCards)
            {
                foreach (var card in newCards)
                {
                    cards.Enqueue(card);
                }
            }
        }
        // creates the deck of cards
        public static class DeckCreator
        {
            public static Queue<Card> CreateCards() 
            
            
            {
                Queue<Card> cards = new Queue<Card>();
                for(int i = 2; i <= 14; i++)
                {
                    foreach(Suit suit in Enum.GetValues(typeof(Suit)))
                    {
                        carsd.Enqueue(new Card()
                        {
                            Suit = suit,
                            Value = i,
                            DisplayName = GetShortName(i, suit)
                        });
                    }
                }
                return Shuffle(cards);
            }
        }
        

    }
}
