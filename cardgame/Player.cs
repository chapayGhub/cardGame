using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Player
    {
        // Variables:
        private String playerName = "";
        private playerDeck playDeck;
        private LootDeck lootDeck;

        // Methods:

        public Player(String name)
        {
            this.playerName = name;
            this.playDeck = new playerDeck();
            this.lootDeck = new LootDeck();
        }

        public void print() 
        {
            Console.WriteLine("Player: " + this.playerName);
            Console.WriteLine("Playdeck:");
            this.playDeck.print();
            Console.WriteLine("Lootdeck:");
            this.lootDeck.print();
        }

    }
}
