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
        public playDeck playDeck;
        public LootDeck lootDeck;

        // Methods:

        public Player(int playerNumber)
        {
            this.playDeck = new playDeck();
            this.lootDeck = new LootDeck();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Enter name of player {0}: ", playerNumber);
            Console.ResetColor();
            this.playerName = Console.ReadLine();
        }

        public string getPlayerName { get { return playerName; } }

        public decimal compareValue(int category)
        {
            return this.playDeck.compare(category);
        }
        
        public int currentDeckSize()
        {
            return lootDeck.Count() + playDeck.Count();
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
            Console.WriteLine();
        }

    }
}
