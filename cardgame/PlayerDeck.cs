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

        //Virker ikke hvis playerDeck er "casted" til Deck???????
        public void draw()
        {
            //player.add(this.cards.ElementAt(1));
            //this.cards.RemoveAt(1);
            Console.WriteLine(this.cards.Count);
        }






    }
}
