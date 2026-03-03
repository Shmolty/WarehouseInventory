using WarehouseInventory;
using static WarehouseInventory.Product;

namespace WarehouseInventoryTesting
{
    [TestClass]
    public class CalculationTestMethods
    {
        [DataRow(259.00, 2.59, 100)]
        [DataRow(218.00, 1.09, 200)]
        [DataRow(262.50, 1.75, 150)]
        [DataRow(400.75, 2.29, 175)]
        [DataRow(686.25, 5.49, 125)]
        [DataTestMethod]
        public void TestCalcValue(double expected, double price, double quantity)
        {
            Product temp = new Product(111, "temp", price, quantity);
            Assert.AreEqual(expected, temp.CalcValue(), 0.001);
        }
    }
}