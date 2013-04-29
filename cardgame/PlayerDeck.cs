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

        public int Count()
        {
            return this.cards.Count();
        }
        
        public void draw(Deck deck)
        {
                Card temp = this.cards.ElementAt(0);
                this.cards.RemoveAt(0);
                deck.add(temp);
        }






    }
}
