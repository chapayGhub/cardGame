using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Deck
    {
        List<Card> cards;

        public Deck()
        {
            this.cards = new List<Card>();
        }

        public void add(Card c)
        {
            this.cards.Add(c);
        }

        public void print()
        {
            Console.WriteLine("Deck contains {0} cards:", this.cards.Count);
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

        public void deal()
        {
            int players = 2;
            int originalDeck = this.cards.Count;
            int cardsPerPlayer = originalDeck / players;

            for (int i = 0; i < players; i++)
            {
                for (int j = 0; j < cardsPerPlayer; j++)
                {
                    //playerDeck.add(this.cards.ElementAt(j));
                }
            }
        }



    } // END DECK
}
