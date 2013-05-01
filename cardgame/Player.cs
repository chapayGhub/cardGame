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

        public int compareValue(string value)
        {
            return this.playDeck.compare(value);
        }

        public void draw()
        {
            if (this.playDeck.Count() == 0)
            {
                //Call some sort of "LOOTDECK GIMME GIMME GIMME!"
                //this.lootDeck.giveDeck();
                //this.playDeck.draw();
            }
            else
            {
            //    this.playDeck.draw();
            }
        }

        public void print() 
        {
            Console.WriteLine("Player: " + this.playerName);
            this.playDeck.print();
            this.lootDeck.print();
        }

    }
}
