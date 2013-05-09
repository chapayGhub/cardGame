using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Score
    {
        //Variables

        //Constructor

        //Methods

        //After each round update the total cardcount of each player
            //If total cardcount == 0 Player is out
            //If only one player remains A WINRAR IS HE!

        //Winner screenprint method because awesome!

        public void winrar(string winrarName)
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
