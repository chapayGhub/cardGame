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

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n GEOGRAPHY CARD GAME\t\n");
            Console.ResetColor();

            // Print ascii-art world map:
            worldMap();
            
            // Get number of players and create player objects:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Enter number of players: ");
            Console.ResetColor();
            int tempPlayers = Convert.ToInt32(Console.ReadLine());
            while (tempPlayers == 0)
            {
                Console.WriteLine();
                Console.WriteLine(" Minimum number of players allowed is 1.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" Enter number of players: ");
                Console.ResetColor();
                tempPlayers = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            createPlayers(tempPlayers);

            // Choose which deck to play and create deck:
            Console.WriteLine(" Choose deck type:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" \tFor countries press 1: ");
            Console.ResetColor();
            int tempDeck = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            createDeck(tempDeck);
        }


        public void createPlayers(int players)
        {
            for (int i = 1; i < players+1; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" Enter name of player {0}: ", i);
                Console.ResetColor();
                String playername = Console.ReadLine();
                this.players.Add(new Player(playername));
                
            }
            Console.WriteLine();

            //Console.WriteLine("Test: Initialising players and decks:");
            //for (int i = 0; i < players; i++ )
            //{
            //    this.players.ElementAt(i).print();
            //}
        }

        public void createDeck(int chosenDeck)
        {
            TotalDeck world = new TotalDeck();
            //Console.WriteLine("Test: Cards imported:");
            PopulateDeck.populate(world);
            //Console.WriteLine();
            //Console.ReadLine();
                        
            Console.WriteLine(" Deck contains the following cards:");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            world.print();
            Console.ResetColor();
            
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Press enter to begin game.");
            Console.ResetColor();
            Console.ReadLine();


            // Deal deck between players:
            world.deal(this.players);
            //this.players.ForEach(Player => Player.print());
            //Console.ReadLine();

        }


        static public void worldMap()
        {
            // Source: www.retrojunkie.com/asciiart/maps/worldmap.htm
            Console.WriteLine(" :::::::::::''  ''::'      '::::::  `:::::::::::::'.:::::::::::::::");
            Console.WriteLine(" :::::::::' :. :  :         ::::::  :::::::::::.:::':::::::::::::::");
            Console.WriteLine(" ::::::::::  :   :::.       :::::::::::::..::::'     :::: : :::::::");
            Console.WriteLine(" ::::::::    :':  '::'     ''::::::::::::: :'           '' ':::::::");
            Console.WriteLine(" :'        : '   :  ::    .::::::::'    '                        .:");
            Console.WriteLine(" :               :  .:: .::. ::::'                              :::");
            Console.WriteLine(" :. .,.        :::  ':::::::::::.: '                      .:...::::");
            Console.WriteLine(" :::::::.      '     .::::::: '''                         :: :::::.");
            Console.WriteLine(" ::::::::            ':::::::::  '',            '    '   .:::::::::");
            Console.WriteLine(" ::::::::.        :::::::::::: '':,:   '    :         ''' :::::::::");
            Console.WriteLine(" ::::::::::      ::::::::::::'                        :::::::::::::");
            Console.WriteLine(" : .::::::::.   .:''::::::::    '         ::   :   '::.::::::::::::");
            Console.WriteLine(" :::::::::::::::. '  '::::::.  '  '     :::::.:.:.:.:.:::::::::::::");
            Console.WriteLine(" :::::::::::::::: :     ':::::::::   ' ,:::::::::: : :.:'::::::::::");
            Console.WriteLine(" ::::::::::::::::: '     :::::::::   . :'::::::::::::::' ':::::::::");
            Console.WriteLine(" ::::::::::::::::::''   :::::::::: :' : ,:::::::::::'      ':::::::");
            Console.WriteLine(" :::::::::::::::::'   .::::::::::::  ::::::::::::::::       :::::::");
            Console.WriteLine(" :::::::::::::::::. .::::::::::::::::::::::::::::::::::::.'::::::::");
            Console.WriteLine(" :::::::::::::::::' :::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine(" ::::::::::::::::::.:::::::::::::::::::::::::::::::::::::::::::::::");
            Console.WriteLine();
        }






    } // END CLASS: GAME
}
