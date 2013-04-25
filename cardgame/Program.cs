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
            Card danmag = new Card("Danmag", 5000000);
            Card swarje = new Card("Swarje", 9000000);
            Card murica = new Card("Murica", 300000000);
            Card inglin = new Card("Inglin", 63000000);
            Card canadia = new Card("Canadia", 34000000);
            Card norja = new Card("Norja", 5000000);

            Deck world = new Deck();
            world.add(danmag);
            world.add(swarje);
            world.add(murica);
            world.add(inglin);
            world.add(canadia);
            world.add(norja);
            
            //world.print();

            //world.shuffle();
            //world.print();

            playerDeck deck1 = new playerDeck();
            playerDeck deck2 = new playerDeck();
            playerDeck deck3 = new playerDeck();

            world.deal(deck1, deck2);
            world.print();
            deck1.print();
            deck2.print();
            deck3.print();
            world.print();
            //deck1.draw(deck2);
            //deck1.print();
            //deck2.print();

            
            Console.ReadLine();
        }
    } // END PROGRAM




    

    
} // END NAMESPACE
