using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class TotalDeck : Deck
    {

        public TotalDeck()
        {
            this.cards = new List<Card>();
            populate();
        }

        public void populate()
        {
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("./decks/test.txt");
            while ((line = file.ReadLine()) != null)
            {
                fixString(line);
            }
            file.Close();

        }

        void fixString(string parameters)
        {
            List<Category> categories = new List<Category>();
            var split = parameters.Split(';');

            // Loop splits string into categoryName, categoryValue, and categoryUnit
            // numberOfSplitsInString-countryName/numberOfFieldsPerCategory
            for (int i = 0; i < (split.Length - 1) / 3; i++)
            {
                // categoryName split follows: 1, 4, 7, 10, 13, 16, ...
                String categoryName = split[3 * i + 1];

                decimal categoryValue;
                // categoryValue split follows: 2, 5, 8, 11, 14, 17, ...
                if (!decimal.TryParse(split[3 * i + 2], out categoryValue))
                {
                    throw new ArgumentException("Split " + 3 * i + 2 + " is not a float");
                }

                // categoryUnit split follows: 3, 6, 9, 12, 15, 18, ...
                String categoryUnit = split[3 * i + 3];

                categories.Add(new Category(categoryName, categoryValue, categoryUnit));
            }

            // Create card:
            this.add(new Card(split[0], categories));

        }


        public void deal(List<Player> players)
        {
            int stacks = players.Count;
            int fullDeck = this.cards.Count;
            int cardsPerPlayer = fullDeck / stacks;

            this.shuffle();

            for (int j = 0; j < stacks; j++)
            {
                for (int i = cardsPerPlayer - 1; i >= 0; i--)
                {
                    players.ElementAt(j).playDeck.add(this.cards.ElementAt(i));
                    this.cards.RemoveAt(i);
                }
            }
        }

    
    }   // END TOTALDECK
}
