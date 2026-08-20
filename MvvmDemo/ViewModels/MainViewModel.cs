using System.ComponentModel;
using System.Runtime.CompilerServices;
using MvvmDemo.Models;

namespace MvvmDemo.ViewModels;

public class MainViewModel : INotifyPropertyChanged
{
	private readonly UserProfile _user = new();

	public string Name
	{
		get => _user.Name;
		set
		{
			if (_user.Name == value)
			{
				return;
			}

			_user.Name = value;
			OnPropertyChanged();
			OnPropertyChanged(nameof(Greeting));
		}
	}

	public string Greeting =>
		string.IsNullOrWhiteSpace(Name)
			? "Enter your name"
			: $"Hello, {Name}!";

	public event PropertyChangedEventHandler? PropertyChanged;

	protected void OnPropertyChanged(
		[CallerMemberName] string? propertyName = null)
	{
		PropertyChanged?.Invoke(
			this,
			new PropertyChangedEventArgs(propertyName));
	}
}