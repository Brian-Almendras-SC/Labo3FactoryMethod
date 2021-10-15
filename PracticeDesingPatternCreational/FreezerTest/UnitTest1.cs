using NUnit.Framework;
using PracticeDesingPatternCreational.Class;

namespace FreezerTest
{
    public class Tests
    {
        SuperMarketStorage AssignmentClass;
        Product FreezerCreation;
        Freezer FreezerExample;
        [SetUp]
        public void Setup()
        {
            AssignmentClass = new ConcreteSuperMarketStorage();
            FreezerCreation = AssignmentClass.GetProduct("Freezer");
            FreezerExample = FreezerCreation as Freezer;
        }

        [Test]
        public void TypeOfMotor()
        {
            FreezerExample.Motor = "V8";
            Assert.AreEqual(FreezerExample.Motor, "V8");
        }
        [Test]
        public void CharactersOftheProduct()
        { 
            var AuxVariable = "ID is: 0, Name of the product is: , Quantity of product is: 0, Location in the storage is: , Type of motor is: ";
            Assert.AreEqual(FreezerExample.CharactersOftheProduct(),AuxVariable);
        }
        [Test]
        public void QuantityOfFreezer()
        {
            FreezerExample.ToStock(10);
            Assert.AreEqual(FreezerExample.stock, 10);
        }
        [Test]
        public void LocationInTheStorage()
        {
            FreezerExample.AssignLocation("v3");
            Assert.AreNotEqual(FreezerExample.LocationInTheStorage(),"V3");
        }
    }
}