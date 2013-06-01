using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    abstract class Deck
    {
        protected List<Card> cards;

        public Deck()
        {
            this.cards = new List<Card>();
        }

        public void add(Card c)
        {
            this.cards.Add(c);
        }

        public virtual void print()
        {
            for (int i = 1; i < this.cards.Count()+1; i++)
            {
                Console.Write(" " + this.cards.ElementAt(i-1).countryName);
                if (i != this.cards.Count())
                {
                    Console.Write(",");
                }
                if (i % 5 == 0)
                {
                    Console.Write("\n");
                }
            }
        }

        public int Count()
        {
            return this.cards.Count();
        }

        public void shuffle()
        {
            Random rng = new Random();
            int i, j, k = 0;
            for (i = 0; i < this.cards.Count * 2; i++)
            {
                for (j = 0; j < this.cards.Count; j++)
                {
                    k = rng.Next(this.cards.Count);
                    Card temp = this.cards[j];
                    this.cards[j] = this.cards[k];
                    this.cards[k] = temp;
                }
            }

        }

        public int getNumberOfCategories()
        {
            return this.cards.ElementAt(0).categoryList.Count;
        }

        public string getContentofOneCategory(int categoryIndex)
        {
            return this.cards.ElementAt(0).printCategory(categoryIndex);
        }

        

    } // END DECK
}
