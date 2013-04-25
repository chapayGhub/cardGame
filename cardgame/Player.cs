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

        // Methods:
        public string player
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public Player(String name)
        {
            this.playerName = name;
            playerDeck playDeck = new playerDeck();
        }



    }
}
