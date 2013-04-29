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
        public LootDeck(Card someCard)
        {
            this.cards = new List<Card>();
            this.add(someCard);
        }

        public override void print()
        {
            Console.WriteLine("LootDeck contains {0} cards:", this.cards.Count);
            base.print();
        }

        public List<Card> giveCardsToPlayerDeck()
        {
            return this.cards;
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
