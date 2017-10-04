using System.Collections.Generic;

namespace DeckDemo
{
    class Player
    {
        public string username { get;set; }
        public double money { get;set; }
        public List<Card> hand { get;set; }

        public Player(string name) {
            username = name;
            money = 1000;
            hand = new List<Card>();
        }

        public Player Draw(Deck d) {
            //pull from the deck
            Card drawnCard = d.Deal();
            //add that card to the player's hand
            hand.Add(drawnCard);
            return this;
        }

        public void ShowHand() {
            System.Console.WriteLine($"{username} has: ");

            for (int i = 0; i < hand.Count; i++) {
                System.Console.WriteLine($"{i}: {hand[i]}");
            }
        }

        public void Discard(int i) {
            // Card c = hand[i];
            hand.RemoveAt(i);
            // return c;
        }
    }
}