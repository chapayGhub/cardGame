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

        public decimal compare(int place)
        {
            return this.cards.ElementAt(0).categoryList.ElementAt(place).returnCategoryValue();
        }

        public void draw(Deck deck)
        {
                Card temp = this.cards.ElementAt(0);
                this.cards.RemoveAt(0);
                deck.add(temp);
        }


        public void showFirstCard()
        {
            Console.WriteLine("\tCountry: " + this.cards.ElementAt(0).countryName);
            this.cards.ElementAt(0).printAllCategories();
            Console.WriteLine();
        }

        public override void print()
        {
            Console.Write("PlayerDeck contains {0} cards: ", this.cards.Count);
            base.print();
        }





    }
}
