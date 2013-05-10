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
        public Card(String cName, params Category[] category)
        {
            countryName = cName;
            categoryList = new List<Category>();
            for (int i = 0; i < category.Length; i++)
            {
                categoryList.Add(category[i]);
            }
        }

        public String printCategory(int val1)
        {
            return this.categoryList.ElementAt(val1).printCategoryContent();
        }

        public void addCategory(Category cat)
        {
            this.categoryList.Add(cat);
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
