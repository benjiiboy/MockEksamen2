using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockEksamen2;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockEksamen2.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarTestDoorsMindreend2()
        {
            //Arrange
            Car car = new Car(Color.Balck, 1, "Golf", "1234567");
            //Act
            int door = car.Doors;
            
            Assert.AreEqual(1,door);

        }

        [TestMethod()]
        public void CarTestDoorsMellem2og5()
        {
            //Arrange
            Car car = new Car(Color.Balck, 3, "BMW", "1234567");

            //Act
            int doors = car.Doors;

            //Assert
            Assert.AreEqual(3, doors);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarTestDoorsover5()
        {
            //Arrange
            Car car = new Car(Color.Balck, 6, "Golf", "1234567");

            //Act
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarTestmodelisnull()
        {
            //Arrange
            Car car = new Car(Color.Balck, 5, null, "1234567");

            //Act
  
        }

        [TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        public void Cartestmodelisnotnull()
        {
            //Arrange
            Car car = new Car(Color.Balck, 4, "golf", "1234567");

            //Act
            //Assert
            Assert.IsNotNull(car.Model);
        }

        [TestMethod()]
        //[ExpectedException(typeof(ArgumentException))]
        public void CarTestregnoer7()
        {
            //Arrange
            Car car = new Car(Color.Balck, 3, "golf", "1234567");

            //Act
            //Assert
            Assert.AreEqual(7, car.RegistrationNo.Length);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CarTestregnorerikke7()
        {
            //Arrange
            Car car = new Car(Color.Balck, 5, "golf", "123456");

            //Act
            Assert.AreEqual(6, car.RegistrationNo.Length);

        }

        //[TestMethod()]
        //public void OwnerTest()
        //{
        //    //Arrange
        //    Owner owner1 = new Owner("Bakkeldaslvej2a", "Benjobob", "12345678");

        //    //Act
        //    Assert.AreEqual(8, owner1.Phone.Length);

        //}


    }
}