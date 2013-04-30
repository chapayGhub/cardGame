using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Card
    {

        // Variables:
        private String countryName = "";
        private int populationSize = 0;

        // Methods:
        // Constructor:
        public Card(String cName, int popSize)
        {
            countryName = cName;
            populationSize = popSize;
        }        
        
        public string Country
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public int Population
        {
            get { return populationSize; }
            set
            {
                if (value > 0) { populationSize = value; }
                else { Console.WriteLine("Please enter non-negative population size"); }
            }
        }

        public void printCardInfo()
        {
            Console.WriteLine("Population of {0} is {1} people.", this.Country, this.Population);
        }

    
    
    }
}
