using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Serilog;

namespace LoggingExceptionDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void LoadFileButton_Click(object sender, RoutedEventArgs e)
    {
        string filePath = "missing-data.txt";

        try
        {
            Log.Information(
                "Attempting to load file {FilePath}",
                filePath);

            string content = File.ReadAllText(filePath);

            StatusText.Text = content;

            Log.Information(
                "Successfully loaded file {FilePath}",
                filePath);
        }
        catch (FileNotFoundException ex)
        {
            Log.Error(
                ex,
                "Failed to load file {FilePath}",
                filePath);

            StatusText.Text =
                "The requested file could not be found. Please check the file and try again.";
        }
    }
}