using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeDesingPatternCreational.Class
{
    public abstract class Product
    {
        //
        protected string Name;
        private long _id;
        protected long Quantity;
        protected string Location;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public long stock{
            get { return Quantity; }
            }
        //Funtions
        public void UpdateBasicAttributes(string Name,long Quantity,string Location)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.Location = Location;
        }
        public abstract void ToStock(int Quantity);
        public abstract string LocationInTheStorage();
        public abstract void AssignLocation(string Location);
        public virtual string CharactersOftheProduct() 
        {
            return $"ID is: {_id}, Name of the product is: {Name}, Quantity of product is: {Quantity}, Location in the storage is: {Location}";
        }
        public object ReturnTypeofProduct()
        {
            return GetType();
        }
    }
}
