using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using EventCommandDemo.Commands;

namespace EventCommandDemo.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
    private string _resultMessage = "Click the button to see the result.";

    public MainViewModel()
    {
        RunCommand = new RelayCommand(_ => RunCommandAction());
    }

    public string ResultMessage
    {
        get => _resultMessage;
        set
        {
            _resultMessage = value;
            OnPropertyChanged();
        }
    }

    public ICommand RunCommand { get; }

    private void RunCommandAction()
    {
        ResultMessage = "Handled by MainViewModel command";
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(
            this,
            new PropertyChangedEventArgs(propertyName));
    }
}