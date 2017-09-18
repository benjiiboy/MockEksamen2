using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockEksamen2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen2.Tests
{
    [TestClass()]
    public class OwnerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestmobilnrer7()
        {
            //Arrange
            Owner owner = new Owner("Bakkedaslvej", "Benjamin", "3011220");

            //Act

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestmobilnrer9()
        {
            //Arrange
            Owner owner = new Owner("Bakkedaslvej", "Benjamin", "123456789");

            //Act

        }

        [TestMethod()]
        public void OwnerTestmobilnrer8()
        {
            //Arrange
            Owner owner = new Owner("Bakkedaslvej", "Benjamin", "12345678");

            //Act

            //Assert
            Assert.AreEqual(8, owner.Phone.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestnameunder4()
        {
            //Arrange
            Owner owner = new Owner("Bakkedaslvej", "ole", "12345678");

            //Act

        }

        [TestMethod()]
        public void OwnerTestnameover4()
        {
            //Arrange
            Owner owner = new Owner("Bakkedaslvej", "benjamin", "12345678");

            //Act

            //Assert
            Assert.AreEqual(8, owner.Name.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestaddressunder6()
        {
            //Arrange
            Owner owner = new Owner("Bakke", "benjamin", "12345678");

            //Act

        }

        [TestMethod()]
        public void OwnerTestaddressover6()
        {
            //Arrange
            Owner owner = new Owner("Bakkedalsvej", "benjamin", "12345678");

            //Act

            //Assert
            Assert.AreEqual(12,owner.Address.Length);
        }
    }
}