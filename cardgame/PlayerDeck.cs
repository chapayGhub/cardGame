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
        List<Card> cards1;

        public playerDeck()
        {
            this.cards1 = new List<Card>();
        }

        
        public void draw()
        {

            //player.add(this.cards.ElementAt(1));
            //this.cards.RemoveAt(1);
            //Console.WriteLine(this);
        }






    }
}
