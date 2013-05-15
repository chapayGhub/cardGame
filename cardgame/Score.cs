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
        static public void checkScore(List<Player> players)
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
            int tempLargestDeck = 0;
            Player tempWinner = new Player("tempPlayer");

            Score.printScoreboard(players);

            foreach (Player playerId in players)
            {   
                if (playerId.currentDeckSize() > tempLargestDeck)
                {
                    tempLargestDeck = playerId.currentDeckSize();
                    tempWinner = playerId;
                }
            }
            
            Score.winrar(tempWinner.getPlayerName);
        }
        //Winner screenprint method because awesome!
        static public void winrar(string winrarName)
        {
            Console.WriteLine(" ********************************************************");
            Console.WriteLine(" ***************    A WINRAR IS YOU!!    ****************");
            Console.WriteLine(" ********************************************************");
            Console.WriteLine("          ***************************************        ");
            Console.WriteLine("                      >>>>>" + winrarName + "<<<<<");
            Console.WriteLine("          ***************************************        ");
            Console.WriteLine(" ********************************************************");
            Console.WriteLine(" ***************    A WINRAR IS YOU!!    ****************");
            Console.WriteLine(" ********************************************************");
        }


    }
}
