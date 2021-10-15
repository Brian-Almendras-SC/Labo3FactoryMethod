using NUnit.Framework;
using PracticeDesingPatternCreational.Class;

namespace CreateSuperMarketStorageTest
{
    public class Tests
    {
        SuperMarketStorage AssignmentClass;
        Product FreezerExample;
        Product VegetableExample;
        [SetUp]
        public void Setup()
        {
            AssignmentClass = new ConcreteSuperMarketStorage();
            VegetableExample = AssignmentClass.GetProduct("Vegetable");
            FreezerExample = AssignmentClass.GetProduct("Freezer");
        }

        [Test]
        public void AssignmentClassToFreezerExample()
        {

            var AuxClassOne = FreezerExample.GetType();
            var AuxClassTwo = FreezerExample.ReturnTypeofProduct();
            Assert.AreEqual(FreezerExample.ReturnTypeofProduct(), FreezerExample.GetType());
            //Assert.Pass();
        }
        [Test]
        public void AssignmentClassToVegetableExample()
        {
            var AuxClassOne = VegetableExample.GetType();
            var AuxClassTwo = VegetableExample.ReturnTypeofProduct();
            Assert.AreEqual(AuxClassTwo, AuxClassOne);
        }
        [Test]
        public void AssignamentoToIDProduct()
        {
            VegetableExample.Id =1;
            Assert.IsTrue(VegetableExample.Id == 1);
        }
    }
}