<!-- cspell:ignore MVVM -->

# Event Handling & Commands Reflection

## Standard Event Handling

In the first version of the WPF application, I handled a button click using a direct event handler.

The button used:

```xml
Click="RunEventButton_Click"
```

The event handler was defined in `MainWindow.xaml.cs`:

```csharp
private void RunEventButton_Click(object sender, RoutedEventArgs e)
{
    ResultText.Text = "Handled directly by MainWindow.xaml.cs";
}
```

I built the project successfully using `dotnet build` and ran it using `dotnet run`. When I clicked the **Run Event** button, the displayed text changed to:

```text
Handled directly by MainWindow.xaml.cs
```

This demonstrated direct event handling in WPF, where the View is connected directly to code-behind.

## Refactoring to a Command

I then refactored the same interaction to use the MVVM command approach.

I created a `RelayCommand` class that implements the `ICommand` interface and a `MainViewModel` that exposes:

```csharp
public ICommand RunCommand { get; }
```

The button was changed from using a `Click` event to command binding:

```xml
Command="{Binding RunCommand}"
```

The result text was also changed to use data binding:

```xml
Text="{Binding ResultMessage}"
```

The window's `DataContext` was set to an instance of `MainViewModel`.

After building and running the refactored version, clicking the **Run Command** button changed the text to:

```text
Handled by MainViewModel command
```

This verified that the user interaction was handled through the ViewModel rather than a direct event handler.

## How Commands Improve Maintainability

Commands improve maintainability because interaction logic can be separated from the View and placed inside the ViewModel.

With direct event handling, methods such as `RunEventButton_Click` are stored in `MainWindow.xaml.cs`, and the code can directly manipulate UI controls. As an application grows, this can lead to a large amount of code-behind that is closely coupled to the UI.

With commands, the View only binds to an action such as `RunCommand`. The actual logic is stored in the ViewModel. This makes responsibilities clearer and makes the logic easier to reuse, change, and test independently of the UI.

The comparison in my example was:

```text
Event approach:
Button -> Click event -> MainWindow.xaml.cs -> UI control

Command approach:
Button -> ICommand -> MainViewModel -> bound property -> UI
```

## When Commands Are More Beneficial

Commands are particularly useful for actions that represent application behaviour or business logic, such as:

* Save
* Delete
* Submit
* Login
* Refresh
* Add an item

These actions may be triggered from different UI elements and benefit from being kept separate from the View.

Event handlers can still be useful for simple behaviour that is closely related to a specific UI control, such as some mouse interactions, animations, or other View-specific behaviour.

## Challenges When Implementing Commands

One challenge is that commands require more setup than a simple event handler. For this task, I needed to create a `RelayCommand` implementation and connect the View to the ViewModel.

Another challenge is understanding how `ICommand`, `Execute`, `CanExecute`, data binding, and `DataContext` work together.

Incorrect bindings can also be difficult to diagnose. For example, if the `DataContext` is missing or a command property name is incorrect, the application may compile but clicking the button may not perform the expected action.

`CanExecute` can also add complexity because the application needs to correctly determine when a command should be enabled or disabled and notify WPF when that state changes.

## Conclusion

This exercise showed me the difference between directly responding to an event and representing a user action as a command.

Direct event handling is simple and useful for small or View-specific interactions. Commands require more initial setup but provide better separation of concerns and fit naturally with the MVVM pattern.

By implementing and testing both approaches, I could see how commands reduce direct dependencies between UI controls and application logic.
