using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {


        Car test_car;

        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }

        //TODO: constructor sets gasTankLevel properly
        [TestMethod]
        public void TestInitialGasTank()
        {
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void TestCarDrive()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestCarDrivePastLimit()
        {
            test_car.Drive(5000);
            Assert.AreEqual(0, test_car.GasTankLevel, 1);
        }
        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestCarOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Should not get here because of the expected Exception");
        }

    }
}