using System;
using System.Collections.Generic;

namespace DeckDemo
{
    class Deck
    {
        public List<Card> cards { get;set; }
        public List<Card> discarded {get;set;}
        
        public Deck() {
            discarded = new List<Card>();
            Reset();
            Shuffle();
        }
        //reset
        public void Reset() {
            cards = new List<Card>();
            string[] suits = {"diamonds", "hearts", "clubs", "spades"};
            //loop through values 1 - 13
            for (int i = 1; i < 14; i++) {
                //loop through each suit
                foreach (string s in suits) {
                    cards.Add(new Card(i, s));
                }
            }
        }

        public void Shuffle() {
            Random rand = new Random();
            for (int i = 0; i < cards.Count; i++) {
                int idx1 = rand.Next(0,cards.Count);
                Card temp = cards[i];
                cards[i] = cards[idx1];
                cards[idx1] = temp;
            }
        }
        
        public Card Deal() {
            Card dealt;
            if (cards.Count == 0) {
                Reset();
            }
            dealt = cards[0];
            // if (cards.Count > 0) {
            //     dealt = cards[0];
            // }
            // else {
            //     return null;
            // }
            cards.RemoveAt(0);
            return dealt;
        }
    }
}