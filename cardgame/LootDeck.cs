using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class LootDeck : Deck
    {
        // Constructor (takes a card object, since no loot without first win):
        public LootDeck()
        {
            this.cards = new List<Card>();
        }

        public override void print()
        {
            Console.WriteLine("LootDeck contains {0} cards:", this.cards.Count);
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
         
        


        
        public void lootTest(params Card[] someCards)
        {
            Console.WriteLine("LootDeck test: Adding cards:");
            for (int i = 0; i < someCards.Length; i++)
            {
                this.add(someCards[i]);
            }
            
            this.print();

            Console.WriteLine("LootDeck test: Shuffle method:");
            this.shuffle();
            this.print();
        }
        


    }
}
