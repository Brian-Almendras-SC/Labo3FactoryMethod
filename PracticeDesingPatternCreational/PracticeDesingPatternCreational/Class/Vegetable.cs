using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesingPatternCreational.Class
{
    public class Vegetable : Product
    {
        public override void AssignLocation(string Location)
        {
            this.Location = Location;
        }

        public override string LocationInTheStorage()
        {
            return Location;
        }

        public override void ToStock(int Quantity)
        {
            this.Quantity = Quantity;
        }
        public override string CharactersOftheProduct()
        {
            return base.CharactersOftheProduct();
        }
     
    }
}
