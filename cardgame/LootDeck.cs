using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class LootDeck : Deck
    {
        // Declare list of card objects:
        List<Card> cards;

        // Constructor (takes a card object, since no loot without first win):
        public LootDeck(Card someCard)
        {
            this.cards = new List<Card>();
            this.add(someCard);
        }



        /*
        public void lootTest(params Card[] )
        {
            Console.WriteLine("Test: Adding cards:");
            this.add();
            this.add();
            this.print();

            Console.WriteLine("Test: Shuffle method:");
            this.shuffle();
            this.print();
        }
        */


    }
}
