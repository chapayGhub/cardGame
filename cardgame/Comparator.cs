using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    static class Comparator
    {
        public static void compareCategory(Player p1, Player p2, int s1)
        {
            float val1 = p1.compareValue(s1);
            float val2 = p2.compareValue(s1);

            if (val1 > val2)
            {
                Console.WriteLine("{0} wins the round", p1.getPlayerName );
                p1.getLootCard(p1);
                p2.getLootCard(p1);
            }   
            if(val1 < val2)
            {
                Console.WriteLine("{0} wins the round", p2.getPlayerName );
                p1.getLootCard(p2);
                p2.getLootCard(p2);
            }

            if (val1 == val2)
            {
                Random rnd = new Random();
                // TODO: (20130507, sbm) If more than 2 players this needs to be rewritten:
                var determineRandomWinner = rnd.Next(1, 3);
                Console.WriteLine("It's a draw! Player {0} is the randomly chosen winner.", determineRandomWinner);
                if (determineRandomWinner == 1)
                {
                    p1.getLootCard(p1);
                    p2.getLootCard(p1);
                }
                else
                {
                    p1.getLootCard(p2);
                    p2.getLootCard(p2);
                }

            }

        }
    }
}
