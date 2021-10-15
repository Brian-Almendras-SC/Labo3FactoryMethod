using NUnit.Framework;
using PracticeDesingPatternCreational.Class;

namespace SuperMarketSotrage.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            SuperMarketStorage storageOne = new ConcreteSuperMarketStorage();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}