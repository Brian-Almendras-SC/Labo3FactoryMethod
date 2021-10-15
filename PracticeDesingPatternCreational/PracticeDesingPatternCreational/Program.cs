using PracticeDesingPatternCreational.Class;
using System;

namespace PracticeDesingPatternCreational
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarketStorage StorageOne = new ConcreteSuperMarketStorage();

            Product freezer = StorageOne.GetProduct("Freezer");
            Product Apple = StorageOne.GetProduct("Vegetable");

            freezer.ToStock(10);
            Console.WriteLine(freezer.CharactersOftheProduct());
            freezer.UpdateBasicAttributes("LG_Freezer",10,"A-5");
            freezer.Id = 1;
            Console.WriteLine(freezer.CharactersOftheProduct());
            Console.WriteLine(freezer.GetType());
        }
    }
}
