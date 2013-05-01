using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    static class Comparator
    {
        public static void doSomething(Player p1, Player p2, string s1)
        {
            int val1 = p1.compareValue(s1);
            int val2 = p2.compareValue(s1);

            if (val1 > val2)
            {
                Console.WriteLine("{0} wins the round", p1.getPlayerName );
                p1.getLootCard(p1);
                p2.getLootCard(p1);
            }   
            else
            {
                Console.WriteLine("{0} wins the round", p2.getPlayerName );
                p1.getLootCard(p2);
                p2.getLootCard(p2);
            }

        }
    }
}
