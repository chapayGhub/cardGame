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
                Console.Write(" {0}\t", players[i].getPlayerName);
                Console.Write(" {0}:\t", players[i].playDeck.FirstCardName() );
                Console.Write( players[i].playDeck.getSomeCategoryContent(selectedCategory) );
                Console.WriteLine();

            }

            // Gets maximum value in value array and get the index of the maximum value:
            decimal maxValue = value.Max();
            int maxIndex = value.ToList().IndexOf(maxValue);


            // Gives loot to winner, checkScore and announce:
            //Console.Clear();
            Console.Write(" {0} won the round and gets the following loot cards: ", players[maxIndex].getPlayerName);
            for (int j = 0; j < players.Count; j++)
            {
                Console.Write(players[j].playDeck.FirstCardName() + "; ");
                players[j].getLootCard(players[maxIndex]);
            }
            
            Score.checkScore(gameName, gameName.players, maxIndex);
            

            // TODO: Make sure that the winner is random, if two or more players have same value.
        }

        
    
    } // END CLASS: COMPARATOR
}
