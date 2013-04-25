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
        List<Card> cards;

        public playerDeck()
        {
            this.cards = new List<Card>();
        }

        
        public Card draw()
        {
            Card temp = this.cards.ElementAt(0);
            this.cards.RemoveAt(0);
            return temp;
        }






    }
}
