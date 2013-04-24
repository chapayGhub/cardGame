using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class playerDeck : Deck
    {
        List<Card> cards;

        public playerDeck()
        {
            this.cards = new List<Card>();
        }
        public Card draw(playerDeck player)
        {
            player.add(this.cards.ElementAt(0));
            //this.clear(this.cards.ElementAt(0));  Clear the card that was drawn from the playerdeck
        }
    }





}
