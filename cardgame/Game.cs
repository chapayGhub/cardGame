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
            worldMap();
            Console.Write(" Enter number of players: ");
            
            int tempPlayers = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            createPlayers(tempPlayers);

            Console.WriteLine(" Choose deck type:");
            Console.Write(" For countries press 1: ");
            int tempDeck = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            createDeck(tempDeck);
        }


        public void createPlayers(int players)
        {
            for (int i = 1; i < players+1; i++)
            {
                Console.Write(" Enter name of player {0}: ", i);
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
            world.print();
            Console.WriteLine();
            Console.ReadLine();

            //Console.WriteLine("Test: The cards have been dealt in the following way:");
            world.deal(this.players);
            Console.WriteLine("Cards have been dealt.");
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
