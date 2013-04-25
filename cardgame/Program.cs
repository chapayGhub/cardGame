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
            Deck world = new Deck();
            
            // Populate overall deck with premade cards:
            world.add(danmag);
            world.add(swarje);
            world.add(murica);
            world.add(inglin);
            world.add(canadia);
            world.add(norja);
            
            // Print the contents of the overall deck:
            //world.print();

            // Shuffle the overall deck:
            //world.shuffle();
            //world.print();


            // Create separate player decks:
            playerDeck deck1 = new playerDeck();
            playerDeck deck2 = new playerDeck();
                        
            world.print();

            // Deal contents of overall deck into separate player decks:
            world.deal(deck1, deck2);
            
            // Print contents of player decks:
            deck1.print();
            deck2.print();
            
            
            // Draw card from player deck:
            deck1.draw();
            deck1.print();

            
            Console.ReadLine();
        }
    } // END PROGRAM




    

    
} // END NAMESPACE
