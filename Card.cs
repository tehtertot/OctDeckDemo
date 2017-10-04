namespace DeckDemo
{
    class Card
    {
        public int val { get; set; }
        public string suit { get; set; }
        public string name { get; set; }

        public Card(int v, string s) {
            val = v;
            suit = s;
            if (v == 1) {
                name = "Ace";
            }
            else if (v == 11) {
                name = "Jack";
            }
            else if (v == 12) {
                name = "Queen";
            }
            else if (v == 13) {
                name = "King";
            }
            else {
                name = v.ToString();
            }
        }

        public override string ToString() {
            return $"{name} of {suit}";
        }        
    }
}