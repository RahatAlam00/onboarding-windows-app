<!-- cspell:ignore MVVM -->

# Data Binding and MVVM Reflection

## What is data binding in WPF?

Data binding connects UI properties to data or presentation logic so that the interface can display and update values without manually assigning them in code-behind.

WPF supports several binding modes:

- `OneWay` updates the UI when the source changes.
- `TwoWay` updates both the UI and the source.
- `OneTime` copies the source value once.
- `OneWayToSource` updates only the source from the UI.
- `Default` uses the default binding mode of the target property.

## How does MVVM organise code?

The Model contains application data and business entities.

The View contains the XAML user interface.

The ViewModel contains presentation logic and exposes properties and commands for the View to bind to.

In my example, `UserProfile` is the Model, `MainWindow.xaml` is the View, and `MainViewModel` is the ViewModel.

## Common pitfalls

Common problems include incorrect binding paths, missing `DataContext`, forgetting to implement `INotifyPropertyChanged`, using an inappropriate binding mode, and placing too much logic in code-behind.

Binding errors may also fail silently in the UI, so checking Visual Studio's debug output can be important.

## Reflection

### How does data binding improve separation of concerns?

Data binding lets the View display and edit values exposed by the ViewModel without tightly coupling the UI to the application logic.

This makes the XAML responsible for presentation while the ViewModel remains responsible for state and presentation behaviour.

### How can MVVM simplify testing and maintenance?

Because logic is moved out of the View, the ViewModel can be tested without opening the UI.

Changes to the XAML layout can also be made without rewriting the underlying logic, while the ViewModel can evolve without redesigning the interface.

### What challenges might arise in larger applications?

Larger applications may contain many ViewModels, commands, bindings, and shared services.

It can become difficult to understand where data originates, diagnose broken bindings, manage navigation, and keep ViewModels from becoming too large.

Clear project structure, consistent naming, reusable services, commands, and automated tests can reduce these problems.

## Practical exercise

I created a simple WPF application using a Model, View, and ViewModel.

A `TextBox` uses `TwoWay` binding to update the `Name` property in the ViewModel as the user types.

The ViewModel implements `INotifyPropertyChanged`, allowing the `Greeting` property to notify the UI when it changes.

A `TextBlock` binds to `Greeting`, so the displayed message updates automatically without directly changing the control from C# code.

This exercise helped me understand how data binding allows the View and ViewModel to communicate while keeping presentation logic separate from the UI.
