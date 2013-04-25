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

        // Methods:
        public string player
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public Player(String name)
        {
            this.playerName = name;
            this.playDeck = new playerDeck();
        }

        public void print() 
        {
            Console.WriteLine(this.playerName);
            this.playDeck.print();
        }

        public string streng() {
            return "Jeg hedder " + this.playerName + " Jeg har disse kort: " + this.playDeck ;
        }

    }
}
