using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class LootDeck : Deck
    {
        // Constructor:
        public LootDeck()
        {
            //this.cards = new List<Card>();
        }

        public override void print()
        {
            Console.Write("LootDeck contains {0} cards: ", this.cards.Count);
            base.print();
        }

        
        public void giveDeck(Deck deck)
        {
            foreach (var card in this.cards)
            {
                deck.add(card);
            }

            this.cards.Clear();
        }




    }
}
