using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
using System;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        //TODO: constructor sets gasTankLevel properly
        //TODO: gasTankLevel is accurate after driving within tank range
        
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            var testCar = new Car("Toyota", "Prius", 10, 50);

            testCar.Drive(50);

            Assert.AreEqual(9, testCar.GasTankLevel, .001);
        }

        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void TestTankAfterExceedingTankRange()
        {
            var testCar = new Car("Toyota", "Prius", 10, 50);

            double maxDistance = testCar.MilesPerGallon * testCar.GasTankLevel;
            testCar.Drive(500);

            Assert.AreEqual(0, testCar.GasTankLevel, .001);
        }
        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            var testCar = new Car("Toyota", "Prius", 10, 50);
            testCar.AddGas(5);
            Assert.Fail("Should not get here, car cannot have more gas in tank than the size of the gas tank.");
        }

    }
}
