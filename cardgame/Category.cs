using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardgame
{
    public class Category
    {
        String categoryName { get; set; }
        float categoryValue { get; set; }
       
        public Category(String name, float value)
        {
            categoryName = name;
            categoryValue = value;
        }

        public string printCategoryContent()
        {
            return categoryName + ":" + categoryValue;
        }
        public float returnCategoryValue()
        {
            return this.categoryValue;
        }


    }
}
