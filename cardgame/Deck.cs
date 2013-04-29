using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Deck
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
            foreach (var card in this.cards)
                Console.WriteLine("{0}, population: {1}", card.Country, card.Population);
            Console.WriteLine();

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

        public void deal(params playerDeck[] players)
        {
            
            int stacks = players.Length;
            int fullDeck = this.cards.Count;
            int cardsPerPlayer = fullDeck/stacks;

            this.shuffle();
            
            for(int j =  0; j < stacks; j++)
            {
                for (int i = cardsPerPlayer-1; i >= 0; i--)
                {
                    players[j].add(this.cards.ElementAt(i));
                    this.cards.RemoveAt(i);
                }
            }
            
        }



    } // END DECK
}
