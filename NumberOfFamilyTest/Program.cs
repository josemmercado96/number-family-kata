using System;
using System.Collections.Generic;

namespace NumberOfFamilyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Tuple<string, string>>
            {
                new Tuple<string, string> ("john", "jane"),
                new Tuple<string, string> ("john", "peter"),
                new Tuple<string, string> ("kirk", "tom"),
                new Tuple<string, string> ("john", "samuel"),
                new Tuple<string, string> ("peter", "mark"),
                new Tuple<string, string> ("mark", "sasha"),
                new Tuple<string, string> ("tom", "erika")
            };
            var familyInstance = new Family();
            int numberOfFamilies = familyInstance.DistinctFamilies(list);
            Console.WriteLine(numberOfFamilies);
        }
    }
}
