using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Game
    {
        public List<Player> players;

        public Game()
        {
            this.players = new List<Player>();

            Console.Write("Whalecum to game! Please enter mounts of platers: ");
            int tempPlayers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            createPlayers(tempPlayers);

            Console.WriteLine("Wat deck would you like to use??? Choose one of the following decks:");
            Console.Write("For countries press 1: ");
            int tempDeck = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            createDeck(tempDeck);
        }


        public void createPlayers(int players)
        {
            for (int i = 1; i < players+1; i++)
            {
                Console.Write("Player {0} name enter plx: ", i);
                String playername = Console.ReadLine();
                this.players.Add(new Player(playername));
                
            }
            Console.WriteLine();

            for (int i = 0; i < players; i++ )
            {
                this.players.ElementAt(i).print();
            }
        }

        public void createDeck(int chosenDeck)
        {
            TotalDeck world = new TotalDeck();
            PopulateDeck.populate(world);
            world.print();

            world.deal(this.players);
            this.players.ForEach(Player => Player.print());

        }





    } // END CLASS: GAME
}
