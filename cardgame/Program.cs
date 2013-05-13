using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Program
    {
        static void Main(string[] args)
        {   
            Game gameid = new Game();
            Turn.firstRound(gameid);

            Console.ReadLine();
        }
    } // END PROGRAM




    

    
} // END NAMESPACE
