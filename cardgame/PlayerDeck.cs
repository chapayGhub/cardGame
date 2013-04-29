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

        
        public void draw(Deck deck)
        {
            if (this.cards.Count == 0)
            {
                
            }
            else
            {
                Card temp = this.cards.ElementAt(0);
                this.cards.RemoveAt(0);
                deck.add(temp);
            }
        }






    }
}
