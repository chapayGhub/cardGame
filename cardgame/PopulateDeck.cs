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
                     //Console.WriteLine (line);
                     PopulateDeck.fixString(line, deck);
                     counter++;
                }
                //Console.WriteLine(counter + " cards added to " + deck);
                file.Close();

        }

        static void fixString(string parameters, Deck deck)
        {
            List<Category> categories = new List<Category>();
            var split = parameters.Split(';');

            // Loop splits string into categoryName, categoryValue, and categoryUnit
            // numberOfSplitsInString-countryName/numberOfFieldsPerCategory
            for (int i = 0; i < (split.Length-1)/3; i++)
            {
                // categoryName split follows: 1, 4, 7, 10, 13, 16, ...
                String categoryName = split[3 * i + 1];

                float categoryValue;
                // categoryValue split follows: 2, 5, 8, 11, 14, 17, ...
                if (!float.TryParse(split[3 * i + 2], out categoryValue))
                {
                    throw new ArgumentException("Split " + 3*i+2 + " is not a float" );
                }
                
                // categoryUnit split follows: 3, 6, 9, 12, 15, 18, ...
                String categoryUnit = split[ 3 * i + 3];
                
                categories.Add(new Category(categoryName, categoryValue, categoryUnit));
            }

            // Create card:
            deck.add(new Card(split[0], categories));
             
        }

    }
}
