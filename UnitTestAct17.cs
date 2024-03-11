using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VehicleInterfaceExample.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Drive_WithNonZeroGasoline_ShouldPrintDriving()
        {
            Car car = new Car(10);
            string expected = "Driving";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                car.Drive();
                string result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void Drive_WithZeroGasoline_ShouldPrintOutOfGas()
        {
            Car car = new Car(0);
            string expected = "Out of gas, cannot drive";
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                car.Drive();
                string result = sw.ToString().Trim();
                Assert.AreEqual(expected, result);
            }
        }

        [TestMethod]
        public void Refuel_WithPositiveAmount_ShouldIncreaseGasoline()
        {
            Car car = new Car(0);
            int amountToRefuel = 20;
            bool result = car.Refuel(amountToRefuel);
            Assert.IsTrue(result);
            Assert.AreEqual(amountToRefuel, car.Gasoline);
        }

        [TestMethod]
        public void Refuel_WithNegativeAmount_ShouldNotChangeGasoline()
        {
            Car car = new Car(10);
            int amountToRefuel = -10;
            bool result = car.Refuel(amountToRefuel);
            Assert.IsFalse(result);
            Assert.AreEqual(10, car.Gasoline);
        }
    }
}
