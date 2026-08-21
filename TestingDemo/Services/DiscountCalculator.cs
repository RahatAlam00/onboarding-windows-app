namespace TestingDemo.Services;

public class DiscountCalculator
{
    public decimal CalculateFinalPrice(
        decimal originalPrice,
        decimal discountPercentage)
    {
        if (originalPrice < 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(originalPrice),
                "Original price cannot be negative.");
        }

        if (discountPercentage < 0 || discountPercentage > 100)
        {
            throw new ArgumentOutOfRangeException(
                nameof(discountPercentage),
                "Discount percentage must be between 0 and 100.");
        }

        decimal discountAmount =
            originalPrice * (discountPercentage / 100);

        return originalPrice - discountAmount;
    }
}
