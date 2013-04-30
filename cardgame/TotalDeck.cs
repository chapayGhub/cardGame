using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class TotalDeck : Deck
    {

        public TotalDeck()
        {
            this.cards = new List<Card>();
        }


        public void deal(params playerDeck[] players)
        {

            int stacks = players.Length;
            int fullDeck = this.cards.Count;
            int cardsPerPlayer = fullDeck / stacks;

            this.shuffle();

            for (int j = 0; j < stacks; j++)
            {
                for (int i = cardsPerPlayer - 1; i >= 0; i--)
                {
                    players[j].add(this.cards.ElementAt(i));
                    this.cards.RemoveAt(i);
                }
            }
        }

    
    }   // END TOTALDECK
}
