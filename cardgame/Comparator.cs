using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    static class Comparator
    {
        public static void compareCategory(int selectedCategory, List<Player> players, Game gameName)
        {
            // TODO: delete testing writelines.

            // Make array of category values that correspond to the index of the list of players:
            float[] value = new float[players.Count];
            for (int i = 0; i < players.Count; i++)
            {
                value[i] = players[i].compareValue(selectedCategory);
                Console.WriteLine("Value at index[{0}]: {1}", i, value[i]);
            }

            // Get maximum value in value array and get the index of the maximum value:
            float maxValue = value.Max();
            Console.WriteLine("Maximum value: {0}", maxValue);
            int maxIndex = value.ToList().IndexOf(maxValue);
            Console.WriteLine("Index of maxValue: {0}", maxIndex);
            Console.WriteLine();

            // Announce winner and give him/her all cards from round:
            Console.WriteLine("{0} wins the round!", players[maxIndex].getPlayerName);
            for (int j = 0; j < players.Count; j++)
            {
                players[j].getLootCard(players[maxIndex]);
            }

            // Give the next turn to winner of this round:
            int winnerOfRound = maxIndex;
            Turn.nextRound(gameName, winnerOfRound);


            // TODO: Make sure that the winner is random, if two or more players have same value.
        }

        // TODO: Make this method, ktnxbye
        public static void roundWinner(Player roundWinner)
        {
            Console.WriteLine("Test: roundWinner method input: {0}", roundWinner.getPlayerName);
        }
    
    } // END CLASS: COMPARATOR
}
