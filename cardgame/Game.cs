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
            TotalDeck allCards = new TotalDeck();
            allCards.deal(this.players);
            round(beginGame());
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

        private int beginGame()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n GAME BEGINS\t");
            Console.ResetColor();

            int numberOfPlayers = players.Count;
            Random rnd = new Random();
            var randomFirstPlayer = rnd.Next(0, numberOfPlayers);
            
            return randomFirstPlayer;

        }

        private void round(int player)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("\n " + players.ElementAt(player).getPlayerName + " ");
            Console.ResetColor();
            Console.WriteLine(" gets to pick next category: ");
            Console.WriteLine();

            players.ElementAt(player).playDeck.showFirstCard();
            compareCategory(selectCategory());

            Console.ReadLine();

        }
        
        private int selectCategory()
        {
            int categoryValue;
            String categorySelected;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Select a category: ");
            Console.ResetColor();
            categorySelected = Console.ReadLine();

            if (categorySelected.ToUpper() == "Q")
            {
                quitScore();
                Console.ReadLine();
                Environment.Exit(0);
            }
            if (categorySelected.ToUpper() == "S")
            {
                Score.printScoreboard(this.players);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(" Select a category: ");
                Console.ResetColor();
                categorySelected = Console.ReadLine();
            }

            while (!Int32.TryParse(categorySelected, out categoryValue) || categoryValue > players.ElementAt(0).playDeck.getNumberOfCategories() - 1 || categoryValue < 0)
            {
                Console.Write(" Not a valid category number. ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Try again: ");
                Console.ResetColor();
                categorySelected = Console.ReadLine();
            }

            Console.WriteLine();
            return categoryValue;

        }

        private void compareCategory(int selectedCategory)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n RESULTS\t\n");
            Console.ResetColor();

            // Makes an array of category values that correspond to the index of the list of players:
            decimal[] value = new decimal[players.Count];
            for (int i = 0; i < players.Count; i++)
            {
                value[i] = this.players[i].compareValue(selectedCategory);
                Console.Write(" {0}\t", this.players[i].getPlayerName);
                Console.Write(" {0}:\t", this.players[i].playDeck.FirstCardName() );
                Console.Write( this.players[i].playDeck.getSomeCategoryContent(selectedCategory) );
                Console.WriteLine();

            }

            // Gets maximum value in value array and get the index of the maximum value:
            decimal maxValue = value.Max();
            int maxIndex = value.ToList().IndexOf(maxValue);


            // Gives loot to winner, checkScore and announce:
            Console.WriteLine();
            Console.Write(" {0} won the round and gets the following loot cards: ", this.players[maxIndex].getPlayerName);
            for (int j = 0; j < this.players.Count; j++)
            {
                Console.Write(this.players[j].playDeck.FirstCardName() + "; ");
                this.players[j].getLootCard(players[maxIndex]);
            }
            Console.WriteLine();

            // Give other in-game options in dark gray:
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" Options: \"q\" quits the game. \"s\" shows the scoreboard ");
            Console.ResetColor();
            Console.WriteLine();


            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n NEW ROUND\t");
            Console.ResetColor();
            
            // Run control of             
            checkScore(maxIndex);
            

            // TODO: Make sure that the winner is random, if two or more players have same value.
        }

        private void checkScore(int winnerOfRound)
        {

            foreach (Player playerId in players.Reverse<Player>())
            {
                int lootCards = playerId.lootDeck.Count();
                int playCards = playerId.playDeck.Count();

                // Remove player from the list of players if she's out of cards:

                if (lootCards + playCards == 0)
                {
                    Console.WriteLine();
                    //Console.WriteLine("Playercount before remove: " + players.Count());
                    Console.WriteLine(" " + playerId.getPlayerName + " is out of cards. Better luck next time!");

                    // If index of removed player is less than winnerOfRound, then decrement index of winnerOfRound
                    if (players.IndexOf(playerId) < winnerOfRound) { winnerOfRound--; }
                    players.Remove(playerId);
                    //Console.WriteLine("Playercount after remove: " + players.Count());
                }

                // If the player's playDeck is empty and she has lootCards, then give them to playDeck:
                if (playCards == 0 && lootCards > 0)
                {
                    playerId.lootDeck.giveDeck(playerId.playDeck);
                }
            }

            // Last man standing gets a textbased celebration and the application exits:
            if (players.Count == 1)
            {
                Score.winrar(players.ElementAt(0).getPlayerName);
                Console.ReadLine();
                Environment.Exit(0);

            }

            // Call nextRound with possibly modified list-index of winnerOfRound:
            round(winnerOfRound);
        }

        private void printScoreboard()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n Scoreboard:\t\n");
            Console.ResetColor();

            var orderedByDeckSize = this.players.OrderBy(x => x.currentDeckSize());
            foreach (Player playerId in orderedByDeckSize.Reverse<Player>())
            {
                Console.WriteLine("\t" + playerId.getPlayerName + " has " + playerId.currentDeckSize() + " cards.");
                //Comment to test commit
            }
            Console.WriteLine();
        }

        private void quitScore()
        {

            printScoreboard();

            var orderedByDeckSize = this.players.OrderByDescending(x => x.currentDeckSize());
            if (orderedByDeckSize.ElementAt(0).currentDeckSize() == orderedByDeckSize.ElementAt(1).currentDeckSize())
            {
                Console.WriteLine(" It's a draw. None of you won!");
            }
            else
            {
                winrar(this.players.ElementAt(0).getPlayerName);
            }

        }

        static public void winrar(string winrarName)
        {
            for (int i = 0; i < 30; i++)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("  ##      ## #### ##    ## ##    ## ######## ########    ");
                Console.WriteLine("  ##  ##  ##  ##  ###   ## ###   ## ##       ##     ##   ");
                Console.WriteLine("  ##  ##  ##  ##  ####  ## ####  ## ##       ##     ##   ");
                Console.WriteLine("  ##  ##  ##  ##  ## ## ## ## ## ## ######   ########    ");
                Console.WriteLine("  ##  ##  ##  ##  ##  #### ##  #### ##       ##   ##     ");
                Console.WriteLine("  ##  ##  ##  ##  ##   ### ##   ### ##       ##    ##    ");
                Console.WriteLine("   ###  ###  #### ##    ## ##    ## ######## ##     ##   ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("\t\tTHE WINNER IS");
                Console.WriteLine("\t\t\t" + winrarName);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  ##      ## #### ##    ## ##    ## ######## ########    ");
                Console.WriteLine("  ##  ##  ##  ##  ###   ## ###   ## ##       ##     ##   ");
                Console.WriteLine("  ##  ##  ##  ##  ####  ## ####  ## ##       ##     ##   ");
                Console.WriteLine("  ##  ##  ##  ##  ## ## ## ## ## ## ######   ########    ");
                Console.WriteLine("  ##  ##  ##  ##  ##  #### ##  #### ##       ##   ##     ");
                Console.WriteLine("  ##  ##  ##  ##  ##   ### ##   ### ##       ##    ##    ");
                Console.WriteLine("   ###  ###  #### ##    ## ##    ## ######## ##     ##   ");
                Console.ResetColor();
                
                for (int j = 0; j < 3000000; j++) { };
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  ##      ## #### ##    ## ##    ## ######## ########    ");
                Console.WriteLine("  ##  ##  ##  ##  ###   ## ###   ## ##       ##     ##   ");
                Console.WriteLine("  ##  ##  ##  ##  ####  ## ####  ## ##       ##     ##   ");
                Console.WriteLine("  ##  ##  ##  ##  ## ## ## ## ## ## ######   ########    ");
                Console.WriteLine("  ##  ##  ##  ##  ##  #### ##  #### ##       ##   ##     ");
                Console.WriteLine("  ##  ##  ##  ##  ##   ### ##   ### ##       ##    ##    ");
                Console.WriteLine("   ###  ###  #### ##    ## ##    ## ######## ##     ##   ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("\t\tTHE WINNER IS");
                Console.WriteLine("\t\t\t" + winrarName);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("  ##      ## #### ##    ## ##    ## ######## ########    ");
                Console.WriteLine("  ##  ##  ##  ##  ###   ## ###   ## ##       ##     ##   ");
                Console.WriteLine("  ##  ##  ##  ##  ####  ## ####  ## ##       ##     ##   ");
                Console.WriteLine("  ##  ##  ##  ##  ## ## ## ## ## ## ######   ########    ");
                Console.WriteLine("  ##  ##  ##  ##  ##  #### ##  #### ##       ##   ##     ");
                Console.WriteLine("  ##  ##  ##  ##  ##   ### ##   ### ##       ##    ##    ");
                Console.WriteLine("   ###  ###  #### ##    ## ##    ## ######## ##     ##   ");
                Console.ResetColor();
                for (int k = 0; k < 3000000; k++) { };


            }
            //Console.ReadLine();


        }

        private void introScreen()
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
