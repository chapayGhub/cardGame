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
                    Console.WriteLine(playerId.getPlayerName + " has no more cards.. Goodbye!");
                    players.Remove(playerId);
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

        //Winner screenprint method because awesome!
        static public void winrar(string winrarName)
        {
            Console.WriteLine("********************************************************");
            Console.WriteLine("***************    A WINRAR IS YOU!!    ****************");
            Console.WriteLine("********************************************************");
            Console.WriteLine("         ***************************************        ");
            Console.WriteLine("                          " + winrarName);
            Console.WriteLine("         ***************************************        ");
            Console.WriteLine("********************************************************");
            Console.WriteLine("***************    A WINRAR IS YOU!!    ****************");
            Console.WriteLine("********************************************************");
        }


    }
}
