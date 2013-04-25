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
        //Jeg har glemt hvad den skulle gøre..
        //Men nu adder den et objekt til den der kalder funktionen og sletter et objekt fra listen

        //Den smider en exception "out of range" eller sådan..
        public void draw(playerDeck player)
        {
            player.cards.Add(this.cards.ElementAt(0));
            this.cards.RemoveAt(0);
        }
    }





}
