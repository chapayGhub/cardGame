using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    static class Comparator
    {
        // TODO: delete testing writelines.
        public static void compareCategory(int selectedCategory, List<Player> players, Game gameName)
        {

            // Makes an array of category values that correspond to the index of the list of players:
            decimal[] value = new decimal[players.Count];
            for (int i = 0; i < players.Count; i++)
            {
                value[i] = players[i].compareValue(selectedCategory);
                //Console.WriteLine("Value at index[{0}]: {1}", i, value[i]);
            }

            // Gets maximum value in value array and get the index of the maximum value:
            decimal maxValue = value.Max();
            int maxIndex = value.ToList().IndexOf(maxValue);
            
            // Save in string because checkScore() rearranges the index of players-list thereby obsoleting maxIndex:
            string roundWinner = players[maxIndex].getPlayerName;
            
            // Gives loot to winner, checkScore and announce:
            Console.Clear();
            Console.Write(" {0} won the round and gets the following loot cards: ", roundWinner);
            for (int j = 0; j < players.Count; j++)
            {
                players[j].playDeck.printFirstCardName();
                players[j].getLootCard(players[maxIndex]);
            }
            
            Score.checkScore(gameName, gameName.players, maxIndex);
            
            // TODO: Perhaps move this to checkScore? Or maybe not, but the nextRound-call is in checkScore ...
            // TODO: If move announcement of winner to checkScore, then replace roundWinner-string here with maxIndex-player
            Console.WriteLine();
            Console.WriteLine("\n {0} gets to pick next category: ", roundWinner);
            Console.WriteLine();




            // TODO: Make sure that the winner is random, if two or more players have same value.
        }

        
    
    } // END CLASS: COMPARATOR
}
