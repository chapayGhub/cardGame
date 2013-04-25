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

        // Deal all cards to players from overall deck and delete it:
        //public void deal(playerDeck player1, playerDeck player2)
        //{
        //    int fullDeck = this.cards.Count;

        //        for (int j = 0; j < fullDeck/2; j++)
        //        {
        //            player1.add(this.cards.ElementAt(j));
        //        }
        //        for (int j = fullDeck/2; j < fullDeck; j++)
        //        {
        //            player2.add(this.cards.ElementAt(j));
        //        }

        //        this.cards.Clear();
        //}

        public void deal(params playerDeck[] players)
        {
            
            int stacks = players.Length;
            int fullDeck = this.cards.Count;
            int cardsPerPlayer = fullDeck/stacks;

            this.shuffle();
            
            for(int j =  0; j < stacks; j++)
            {
                for (int i = 0; i < cardsPerPlayer; i++)
                {
                    players[j].add(this.cards.ElementAt(i));
                    this.cards.RemoveAt(i);
                }
            }
            
        }



    } // END DECK
}
