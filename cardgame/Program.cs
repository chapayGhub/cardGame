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
            // Create cards for overall deck:
            Card danmag = new Card("Danmag", 5000000);
            Card swarje = new Card("Swarje", 9000000);
            Card murica = new Card("Murica", 300000000);
            Card inglin = new Card("Inglin", 63000000);
            Card canadia = new Card("Canadia", 34000000);
            Card norja = new Card("Norja", 5000000);

            // Create list for overall deck:
            TotalDeck world = new TotalDeck();
            
            // Populate overall deck with premade cards:
            world.add(danmag);
            world.add(swarje);
            world.add(inglin);
            world.add(murica);
            world.add(canadia);
            world.add(norja);


            Player jack = new Player("Jack");
            Player jill = new Player("Jill");


            world.deal(jack.playDeck, jill.playDeck);

            jack.print();
            jill.print();

            Comparator.compareCategory(jack, jill, "population");

            jack.print();
            jill.print();

            //Så laver jeg en comment
            Console.ReadLine();
        }
    } // END PROGRAM




    

    
} // END NAMESPACE
