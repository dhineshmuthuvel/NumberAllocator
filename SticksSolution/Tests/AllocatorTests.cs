using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SticksSolution;

namespace Tests
{
    [TestClass]
    public class AllocatorTests
    {
        [TestMethod]
        public void VarianceDistributionIsMinimum()
        {
            Person firstPerson
                = new Person(1,5);
            Person secondPerson
                = new Person(1, 6);
            Person thirdPerson
                = new Person(1, 8);

            List<Person> collectors = new List<Person>(){firstPerson, secondPerson, thirdPerson};

            Allocator allocator = new Allocator();

            allocator.Allocate(50,collectors);

            Assert.IsTrue(firstPerson.NewSticksHolded == 18);
            Assert.IsTrue(secondPerson.NewSticksHolded == 17);
            Assert.IsTrue(thirdPerson.NewSticksHolded == 15);
        }

        [TestMethod]
        public void VarianceDistributionIsBigTest()
        {
            Person firstPerson
                = new Person(1, 11);
            Person secondPerson
                = new Person(1, 12);
            Person thirdPerson
                = new Person(1, 78);

            List<Person> collectors = new List<Person>() { firstPerson, secondPerson, thirdPerson };

            Allocator allocator = new Allocator();

            allocator.Allocate(60,collectors);

            Assert.IsTrue(firstPerson.NewSticksHolded == 31);
            Assert.IsTrue(secondPerson.NewSticksHolded == 29);
            Assert.IsTrue(thirdPerson.NewSticksHolded == 78);
        }

        [TestMethod]
        public void Second_VarianceDistributionIsBigTest()
        {
            Person firstPerson
                = new Person(1, 50);
            Person secondPerson
                = new Person(1, 0);
            Person thirdPerson
                = new Person(1, 0);

            List<Person> collectors = new List<Person>() { firstPerson, secondPerson, thirdPerson };

            Allocator allocator = new Allocator();

            allocator.Allocate(60, collectors);

            Assert.IsTrue(firstPerson.NewSticksHolded == 50);
            Assert.IsTrue(secondPerson.NewSticksHolded == 30);
            Assert.IsTrue(thirdPerson.NewSticksHolded == 30);
        }

        [TestMethod]
        public void Third_VarianceDistributionIsEvenTest()
        {
            Person firstPerson
                = new Person(1, 13);
            Person secondPerson
                = new Person(2, 14);
            Person thirdPerson
                = new Person(3, 15);
            Person fourthPerson
                = new Person(4, 14);
            Person fifthPerson
                = new Person(5, 34);
            Person sixthPerson
                = new Person(6, 4);

            List<Person> collectors = new List<Person>() { firstPerson, secondPerson, thirdPerson, fourthPerson, fifthPerson, sixthPerson };

            Allocator allocator = new Allocator();

            allocator.Allocate(100, collectors);

            Assert.IsTrue(firstPerson.NewSticksHolded == 19);
            Assert.IsTrue(secondPerson.NewSticksHolded == 18);
            Assert.IsTrue(thirdPerson.NewSticksHolded == 17);
            Assert.IsTrue(fourthPerson.NewSticksHolded == 18);
            Assert.IsTrue(fifthPerson.NewSticksHolded == 34);
            Assert.IsTrue(sixthPerson.NewSticksHolded == 28);
        }

        [TestMethod]
        public void SplitterTest()
        {
            List<int> split = Utils.Split(160,5);

            foreach (int i in split)
            {
                Console.WriteLine(i);
            }
        }
    }
}
