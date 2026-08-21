using System.Windows;
using TestingDemo.Services;

namespace TestingDemo;

public partial class MainWindow : Window
{
    private readonly DiscountCalculator _calculator = new();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(
        object sender,
        RoutedEventArgs e)
    {
        if (!decimal.TryParse(
                OriginalPriceTextBox.Text,
                out decimal originalPrice) ||
            !decimal.TryParse(
                DiscountPercentageTextBox.Text,
                out decimal discountPercentage))
        {
            ResultText.Text = "Please enter valid numeric values.";
            return;
        }

        try
        {
            decimal finalPrice =
                _calculator.CalculateFinalPrice(
                    originalPrice,
                    discountPercentage);

            ResultText.Text =
                $"Final price: {finalPrice:C}";
        }
        catch (ArgumentOutOfRangeException ex)
        {
            ResultText.Text = ex.Message;
        }
    }
}
