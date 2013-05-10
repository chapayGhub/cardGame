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

    // TODO: Refactor so string can contain arbitrary number of category-value pairs (if not too difficult).
    static void fixString(string parameters, Deck deck)
    {
        var split = parameters.Split(',');
        // Adjust to number of arguments that the string of parameters contains.
        if (split.Length != 5)
              throw new ArgumentException("Wrong number of parameters in input string");
        
        float a;
        if (!float.TryParse(split[2], out a))
        {
            throw new ArgumentException("Split 2 is not a float");
        }

        float b;
        if (!float.TryParse(split[4], out b))
        {
            throw new ArgumentException("Split 4 is not a float");
        }

        // Create card:
        Category cat1 = new Category(split[1], a);
        Category cat2 = new Category(split[3], b);
        deck.add(new Card(split[0], cat1, cat2));
             
}

    }
}
