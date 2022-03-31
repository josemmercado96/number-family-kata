using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberOfFamilyTest;
using System;
using System.Collections.Generic;

namespace NumberOfFamilyTestTests
{
    [TestClass]
    public class FamilyTests
    {
        [TestMethod]
        public void WhenYouHaveAnEmptyListYouMustReturnZero()
        {
            //ARRANGE
            var family = new Family();
            var list = new List<Tuple<string, string>>();

            //ACT
            var numberOfFamilies = family.DistinctFamilies(list);

            //ASSERT
            Assert.AreEqual(numberOfFamilies, 0);
        }

        [TestMethod]
        public void WhenYouHaveASingleListYouMustReturnOne()
        {
            //ARRANGE
            var family = new Family();
            var list = new List<Tuple<string, string>> { 
                new Tuple<string, string>("jhon", "terry")
            };

            //ACT
            var numberOfFamilies = family.DistinctFamilies(list);

            //ASSERT
            Assert.AreEqual(numberOfFamilies, 1);
        }

        [TestMethod]
        public void WhenYouHaveAListWithTwoDistinctRelationsYouMustReturnTwo()
        {
            //ARRANGE
            var family = new Family();
            var list = new List<Tuple<string, string>> {
                new Tuple<string, string>("jhon", "terry"),
                new Tuple<string, string>("mike", "ivan")
            };

            //ACT
            var numberOfFamilies = family.DistinctFamilies(list);

            //ASSERT
            Assert.AreEqual(numberOfFamilies, 2);
        }

        [TestMethod]
        public void WhenYouHaveAListWithManyRelationsWithTwoDiferentFirstRelationYouMustReturnTwo()
        {
            //ARRANGE
            var family = new Family();
            var list = new List<Tuple<string, string>>
            {
                new Tuple<string, string> ("john", "jane"),
                new Tuple<string, string> ("john", "peter"),
                new Tuple<string, string> ("john", "samuel"),
                new Tuple<string, string> ("peter", "mark"),
                new Tuple<string, string> ("mark", "sasha"),
                new Tuple<string, string> ("kirk", "tom"),
                new Tuple<string, string> ("tom", "erika")
            };

            //ACT
            var numberOfFamilies = family.DistinctFamilies(list);

            //ASSERT
            Assert.AreEqual(numberOfFamilies, 2);
        }

        [TestMethod]
        public void WhenYouHaveAListWithManyRelationsWithOneRelationWithTheFirstRelationAtLastPositionYouMustReturnOne()
        {
            //ARRANGE
            var family = new Family();
            var list = new List<Tuple<string, string>>
            {
                new Tuple<string, string> ("john", "peter"),
                new Tuple<string, string> ("peter", "mark"),
                new Tuple<string, string> ("mark", "sasha"),
                new Tuple<string, string> ("erika", "john")
            };

            //ACT
            var numberOfFamilies = family.DistinctFamilies(list);

            //ASSERT
            Assert.AreEqual(numberOfFamilies, 1);
        }
    }
}
