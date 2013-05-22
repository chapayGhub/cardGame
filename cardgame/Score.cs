using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    static class Score
    {
        //Variables

        //Constructor

        //Methods
        static public void checkScore(Game gameName, List<Player> players, int winnerOfRound)
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
            Turn.nextRound(gameName, winnerOfRound);
        }

        static public void printScoreboard(List<Player> players)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n Scoreboard:\t\n");
            Console.ResetColor();

            var orderedByDeckSize = players.OrderBy(x => x.currentDeckSize());
            foreach (Player playerId in orderedByDeckSize.Reverse<Player>())
            {
                Console.WriteLine("\t" + playerId.getPlayerName + " has " + playerId.currentDeckSize() + " cards.");
                //Comment to test commit
            }
            Console.WriteLine();
        }

        static public void quitScore(List<Player> players)
        {

            Score.printScoreboard(players);

            var orderedByDeckSize = players.OrderBy(x => x.currentDeckSize());
            orderedByDeckSize.Reverse();
            if (orderedByDeckSize.ElementAt(0).currentDeckSize() == orderedByDeckSize.ElementAt(1).currentDeckSize())
            {
                Console.WriteLine(" It's a draw. None of you won!");
            }
            else
            {
                Score.winrar(players.ElementAt(0).getPlayerName);
            }
            
        }
        //Winner screenprint method because awesome!
        static public void winrar(string winrarName)
        {
            for (int i = 0; i < 10; i++ )
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("    ##      ## #### ##    ## ##    ## ######## ########  ");
                Console.WriteLine("    ##  ##  ##  ##  ###   ## ###   ## ##       ##     ## ");
                Console.WriteLine("    ##  ##  ##  ##  ####  ## ####  ## ##       ##     ## ");
                Console.WriteLine("    ##  ##  ##  ##  ## ## ## ## ## ## ######   ########  ");
                Console.WriteLine("    ##  ##  ##  ##  ##  #### ##  #### ##       ##   ##   ");
                Console.WriteLine("    ##  ##  ##  ##  ##   ### ##   ### ##       ##    ##  ");
                Console.WriteLine("     ###  ###  #### ##    ## ##    ## ######## ##     ## ");
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
                for (int j = 0; j < 99999999; j++) { };
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
                Console.WriteLine("    ##      ## #### ##    ## ##    ## ######## ########  ");
                Console.WriteLine("    ##  ##  ##  ##  ###   ## ###   ## ##       ##     ## ");
                Console.WriteLine("    ##  ##  ##  ##  ####  ## ####  ## ##       ##     ## ");
                Console.WriteLine("    ##  ##  ##  ##  ## ## ## ## ## ## ######   ########  ");
                Console.WriteLine("    ##  ##  ##  ##  ##  #### ##  #### ##       ##   ##   ");
                Console.WriteLine("    ##  ##  ##  ##  ##   ### ##   ### ##       ##    ##  ");
                Console.WriteLine("     ###  ###  #### ##    ## ##    ## ######## ##     ## ");
                Console.ResetColor();
                for (int k = 0; k < 99999999; k++) { };
                

            }
            Console.ReadLine();
            

        }


    }
}
