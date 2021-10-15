using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesingPatternCreational.Class
{
    public class ConcreteSuperMarketStorage : SuperMarketStorage
    {
        public override Product GetProduct(string Product)
        {
            switch (Product)
            {
                case "Freezer": return new Freezer();
                case "Vegetable": return new Vegetable();
                default: throw new Exception(string.Format("The product'{0}' cannot be created, try with another",Product));
            }
            
        }
    }
}
