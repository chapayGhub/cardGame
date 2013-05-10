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

                if (lootCards + playCards == 0)
                {
                    //Remove player from the list of players
                    Console.WriteLine(playerId.getPlayerName + " has no more cards.. Goodbye!");
                    players.Remove(playerId);
                }

            }
            if (players.Count == 1)
                {
                    //Assuming all other players has been removed from the list
                    Score.winrar(players.ElementAt(0).getPlayerName);
                    Console.ReadLine();
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
