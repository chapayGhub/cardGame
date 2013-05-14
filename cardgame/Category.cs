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
        String categoryUnit { get; set; }
       
        public Category(String name, float value, String unit)
        {
            categoryName = name;
            categoryValue = value;
            categoryUnit = unit;
        }

        public string printCategoryContent()
        {
            return categoryName + ": " + categoryValue + " " + categoryUnit;
        }
        public float returnCategoryValue()
        {
            return this.categoryValue;
        }


    }
}
