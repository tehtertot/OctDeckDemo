using System;

namespace DeckDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            Player henry = new Player("Henry");
            Player erik = new Player("Erik");
            for (int i = 0; i < 5; i++) {
                henry.Draw(newDeck).Draw(newDeck);
                erik.Draw(newDeck);
            }
            henry.ShowHand();
            erik.ShowHand();

            henry.Discard(1);
            erik.Discard(3);

            henry.ShowHand();
            erik.ShowHand();
            
        }
    }

    
}
