using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace cardgame
{
    class playDeck : Deck
    {

        public playDeck()
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tCountry: " + this.cards.ElementAt(0).countryName);
            Console.ResetColor();
            this.cards.ElementAt(0).printAllCategories();
            Console.WriteLine();
        }

        public override void print()
        {
            Console.Write("PlayerDeck contains {0} cards: ", this.cards.Count);
            base.print();
        }

        public string FirstCardName()
        {
            return this.cards.ElementAt(0).countryName;
        }





    }
}
