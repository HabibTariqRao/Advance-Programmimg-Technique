using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class OrderTests
{
    [TestMethod]
    public void PayBill_ShouldReturnCorrectAmount()
    {
        // Arrange
        Order order = new Order("Chocolate", 2, 8);

        // Act
        double result = order.PayBill();

        // Assert
        Assert.AreEqual(16, result);
    }
}