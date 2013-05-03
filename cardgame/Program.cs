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
            // Create cards:
            TotalDeck world = new TotalDeck();

            world.add(new Card("Danmark","Befolkning",9002));

            world.print();










            //Så laver jeg en comment
            Console.ReadLine();
        }
    } // END PROGRAM




    

    
} // END NAMESPACE
