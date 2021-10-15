using NUnit.Framework;
using PracticeDesingPatternCreational.Class;

namespace VegetableTest
{
    public class Tests
    {
        SuperMarketStorage AssignmentClass;
        Product VegetableCreation;
        Vegetable VegetableExample;
        [SetUp]
        public void Setup()
        {
            AssignmentClass = new ConcreteSuperMarketStorage();
            VegetableCreation = AssignmentClass.GetProduct("Vegetable");
            VegetableExample = VegetableCreation as Vegetable;
        }

        [Test]
        public void CharactersOftheProduct()
        {
            VegetableExample.Id = 1;
            VegetableExample.UpdateBasicAttributes("Tomatoes", 150, "Freezer-15");
            var AuxVariable = "ID is: 1, Name of the product is: Tomatoes, Quantity of product is: 150, Location in the storage is: Freezer-15";
            Assert.AreEqual(VegetableExample.CharactersOftheProduct(), AuxVariable);
        }
        [Test]
        public void QuantityOfVegetable()
        {
            VegetableExample.ToStock(1100);
            Assert.AreNotEqual(VegetableExample.stock, 10000010);
        }
        [Test]
        public void LocationInTheStorage()
        {
            VegetableExample.AssignLocation("Freezer-35");
            Assert.AreNotEqual(VegetableExample.LocationInTheStorage(), "Stage-35");
        }
    }
}