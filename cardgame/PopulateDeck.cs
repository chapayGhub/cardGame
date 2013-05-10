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
        List<Category> categories = new List<Category>();
        var split = parameters.Split(',');

        for (int i = 0; i < (split.Length-1)/2; i++)
        {
            float categoryValue;
            if (!float.TryParse(split[2*i + 2], out categoryValue))
            {
                throw new ArgumentException("Split " + 2*i+2 + " is not a float" );
            }
            categories.Add(new Category(split[2 * i + 1], categoryValue));
        }

        // Create card:
        deck.add(new Card(split[0], categories));
             
}

    }
}
