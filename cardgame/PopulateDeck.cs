using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    static class PopulateDeck
    {
        public static void populate(Deck deck)
    {
        int counter = 0;
        string line;

        // Read the file and display it line by line.
        System.IO.StreamReader file = new System.IO.StreamReader("./decks/test.txt");
            while((line = file.ReadLine()) != null)
            {
                 Console.WriteLine (line);
                 PopulateDeck.fixString(line, deck);
                 counter++;
            }
            Console.WriteLine(counter + " cards added to " + deck);
            file.Close();

    }


         static void fixString(string parameters, Deck deck)
{
    var split = parameters.Split(',');
    if (split.Length != 3)
          throw new ArgumentException("Wrong number of parameters in input string");

    float a;

    if (!float.TryParse(split[2], out a))
    {
        throw new ArgumentException("First parameter in input string is not an integer");
    }
          

    //Createcard..
             deck.add(new Card(split[0],split[1],a));
             
}

    }
}
