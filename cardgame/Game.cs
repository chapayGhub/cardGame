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

            world.dealTwo(this.players);
            this.players.ForEach(Player => Player.print());

        }

        // TODO: Perhaps move this to Turn class.
        // TODO: Make method so player whose turn it is can choose category.
        // Play first round. Method is placed here bc access to list of players.
        public void firstRound()
        {
            Console.Write("Select category [0, 1]: ");
            int selectCategory = Convert.ToInt32(Console.ReadLine());
            Comparator.compareCategory(1, this.players);
        }


    }
}
