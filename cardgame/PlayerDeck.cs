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

        public float compare(int place)
        {
            return this.cards.ElementAt(0).categoryList.ElementAt(place).returnCategoryValue();
        }

        // TODO: Find out if we use this method. If not: Delete
        public void draw(Deck deck)
        {
                Card temp = this.cards.ElementAt(0);
                this.cards.RemoveAt(0);
                deck.add(temp);
        }


        public void showFirstCard()
        {
            // TODO: Print name of country/card here
            this.cards.ElementAt(0).printAllCategories();
        }

        public override void print()
        {
            Console.WriteLine("PlayerDeck contains {0} cards:", this.cards.Count);
            base.print();
        }





    }
}
