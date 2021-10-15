using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesingPatternCreational.Class
{
    public class Freezer : Product
    {
        private string _motor;
        public string Motor
        {
            get
            {
                return _motor;
            }
            set
            {
                _motor = value;
            }
        }
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
            return $"{base.CharactersOftheProduct()}, Type of motor is: {_motor}";
        }
    }
}
