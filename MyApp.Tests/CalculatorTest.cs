using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp;

namespace MyApp.Tests
{
    public class CalculatorTest
    {
        [Test]
        public void Add_Test()
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.Add(2, 3);

            //Assert
            Assert.AreEqual(5, result);
        }

    }
}
