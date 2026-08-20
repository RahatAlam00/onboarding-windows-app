using System.Windows;
using EventCommandDemo.ViewModels;

namespace EventCommandDemo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        DataContext = new MainViewModel();
    }
}