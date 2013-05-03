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
        public Card(String cName, String categoryName, float categoryValue)
        {
            countryName = cName;
            categoryList = new List<Category>();
            categoryList.Add( new Category(categoryName, categoryValue) );
        
        }

        public String printCategory(int val1)
        {
            return this.categoryList.ElementAt(val1).printCategoryContent();
        }




    
    
    }
}
