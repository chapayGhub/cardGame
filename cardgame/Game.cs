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

            introScreen();
            
            createPlayers();
            
            // Instantiate new deck:
            TotalDeck world = new TotalDeck();
            // Deal deck between players:
            world.deal(this.players);
        }


        public void createPlayers()
        {
            // Get number of players and create player objects:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Enter number of players: ");
            Console.ResetColor();
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            while (numberOfPlayers == 0)
            {
                Console.WriteLine();
                Console.WriteLine(" Minimum number of players allowed is 1.");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" Enter number of players: ");
                Console.ResetColor();
                numberOfPlayers = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 1; i < numberOfPlayers+1; i++)
            {
                this.players.Add( new Player( this.players.Count()+1 ) );
                
            }
            Console.WriteLine();
        }


        static public void introScreen()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n GEOGRAPHY GAME\t\n");
            Console.ResetColor();

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
