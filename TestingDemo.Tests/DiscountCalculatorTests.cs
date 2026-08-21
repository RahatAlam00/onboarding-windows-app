using TestingDemo.Services;

namespace TestingDemo.Tests;

[TestClass]
public class DiscountCalculatorTests
{
    private readonly DiscountCalculator _calculator = new();

    [TestMethod]
    public void CalculateFinalPrice_WithTenPercentDiscount_ReturnsNinety()
    {
        decimal result = _calculator.CalculateFinalPrice(100m, 10m);

        Assert.AreEqual(90m, result);
    }

    [TestMethod]
    public void CalculateFinalPrice_WithZeroPercentDiscount_ReturnsOriginalPrice()
    {
        decimal result = _calculator.CalculateFinalPrice(100m, 0m);

        Assert.AreEqual(100m, result);
    }

    [TestMethod]
    public void CalculateFinalPrice_WithHundredPercentDiscount_ReturnsZero()
    {
        decimal result = _calculator.CalculateFinalPrice(100m, 100m);

        Assert.AreEqual(0m, result);
    }

    [TestMethod]
    public void CalculateFinalPrice_WithNegativePrice_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            _calculator.CalculateFinalPrice(-1m, 10m));
    }

    [TestMethod]
    public void CalculateFinalPrice_WithNegativeDiscount_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            _calculator.CalculateFinalPrice(100m, -1m));
    }

    [TestMethod]
    public void CalculateFinalPrice_WithDiscountAboveHundred_ThrowsException()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
            _calculator.CalculateFinalPrice(100m, 101m));
    }
}