using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordOccurrenceCalculator;
using WordOccurrenceCalculator;

namespace WordOccurrenceCalculator
{
    //decorate with video example
    [TestFixture]
    public class CalculateOccurrencesTest
    {
        //decorate
        [Test]
        public void HelloTest()
        {
            //Arrange
            //Setup required to run test
            String stringTest = "one two three test two three";
            //stringAsArrayList.Add("test one two three one");

            //Act
            //Code you want to test
            var actualOutput = WordOccurrence.calculateOccurrences(stringTest);

            //Assert
            //Acts as expected?
            Assert.Pass();
        }

    }
}
