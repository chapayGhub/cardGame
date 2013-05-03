using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace cardgame
{
    class playerDeck : Deck
    {

        public playerDeck()
        {

        }

        public int compare(string value)
        {
            //Indsæt switch case til at kalde de forskellige værdier her!
            switch (value)
            {
                case "population":
                    return this.cards.ElementAt(0).categoryList.Count; //Fix this!!! Returns a dummy atm.
                //case "country": 
                //    return this.cards.ElementAt(0).Country;
                default:
                    Console.WriteLine("Value not found");
                    return 0;
            }
        }

        public void draw(Deck deck)
        {
                Card temp = this.cards.ElementAt(0);
                this.cards.RemoveAt(0);
                deck.add(temp);
        }

        public override void print()
        {
            Console.WriteLine("PlayerDeck contains {0} cards:", this.cards.Count);
            base.print();
        }





    }
}
