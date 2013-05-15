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
        decimal categoryValue { get; set; }
        String categoryUnit { get; set; }
       
        public Category(String name, decimal value, String unit)
        {
            categoryName = name;
            categoryValue = value;
            categoryUnit = unit;
        }

        public string printCategoryContent()
        {
            return categoryName + ": " + categoryValue + " " + categoryUnit;
        }
        public decimal returnCategoryValue()
        {
            return this.categoryValue;
        }


    }
}
