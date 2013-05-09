using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    class Card
    {
        public String countryName { get; private set; }
        public List<Category> categoryList;

        // Constructor:
        // TODO: The card should be able to take n arguments of categoryNames and categoryValues ...
        public Card(String cName, String categoryName, float categoryValue, String categoryName2, float categoryValue2)
        {
            countryName = cName;
            categoryList = new List<Category>();
            categoryList.Add( new Category(categoryName, categoryValue) );
            categoryList.Add(new Category(categoryName2, categoryValue2));
        
        }

        public String printCategory(int val1)
        {
            return this.categoryList.ElementAt(val1).printCategoryContent();
        }

        // This prints all categories on a given card by looping through it via printCategory:
        public void printAllCategories()
        {
            int numberOfCategories = categoryList.Count;
            for (int i = 0; i < numberOfCategories; i++)
            {
                Console.WriteLine(printCategory(i));
            }
        }



    
    
    }
}
