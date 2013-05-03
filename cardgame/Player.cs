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
        public playerDeck playDeck;
        public LootDeck lootDeck;

        // Methods:

        public Player(String name)
        {
            this.playerName = name;
            this.playDeck = new playerDeck();
            this.lootDeck = new LootDeck();
        }

        public string getPlayerName { get { return playerName; } }

        public float compareValue(int category)
        {
            return this.playDeck.compare(category);
        }

        public void getLootCard(Player winner)
        {
              this.playDeck.draw(winner.lootDeck);
        }

        public void print() 
        {
            Console.WriteLine("Player: " + this.playerName);
            this.playDeck.print();
            this.lootDeck.print();
        }

    }
}
