<!-- cspell:ignore Rahat Nmae -->

# Debugging Techniques Reflection

## Visual Studio Debugging Tools

For this exercise, I used several Visual Studio debugging tools while working with a WPF application.

A breakpoint pauses the application at a specific line so that the current program state can be inspected. I placed a breakpoint on:

```csharp
DataContext = this;
```

This allowed me to pause the WPF window during initialization and inspect the data being used by the binding.

The Watch window allowed me to monitor the `UserName` property while the application was paused. It showed:

```text
UserName = "Rahat"
```

This confirmed that the expected value existed in memory.

I also used the Immediate Window and evaluated:

```text
? UserName
```

The result was:

```text
"Rahat"
```

This provided another way to inspect the application's runtime state.

For the WPF-specific issue, I used the XAML Binding Failures window. It reported:

```text
UserNmae property not found on object of type MainWindow.
```

This identified the exact cause of the UI problem.

## Deliberate Bug

The application contained a deliberate WPF data-binding bug.

The actual property in `MainWindow.xaml.cs` was:

```csharp
public string UserName { get; set; } = "Rahat";
```

However, the XAML incorrectly used:

```xml
Text="{Binding UserNmae}"
```

The project still built successfully using `dotnet build`, which demonstrated that some WPF data-binding problems are runtime problems rather than compile-time errors.

When I ran the application, the `User name:` label appeared but the value `Rahat` did not appear in the UI.

## Debugging Process

I first confirmed that the underlying data was correct.

The Watch window showed:

```text
UserName = "Rahat"
```

The Immediate Window also returned:

```text
"Rahat"
```

This showed that the problem was not caused by a missing or incorrect value.

I then checked the XAML Binding Failures window. Visual Studio reported that the `UserNmae` property could not be found on `MainWindow`.

This revealed that the binding path contained a spelling mistake.

I changed:

```xml
Text="{Binding UserNmae}"
```

to:

```xml
Text="{Binding UserName}"
```

After restarting the debugger and continuing past the breakpoint, the WPF window displayed:

```text
User name:
Rahat
```

The XAML Binding Failures window no longer showed the previous error.

## Most Useful Debugging Tools

The XAML Binding Failures window was especially useful for this WPF problem because it directly identified the incorrect binding property name.

The Watch window was also useful because it helped confirm that the application data was correct before I changed the XAML.

The Immediate Window provided a quick way to evaluate the `UserName` property while execution was paused.

Using these tools together helped narrow the problem down instead of guessing.

## Scenario Where Debugging Helped Identify an Issue

In this exercise, the application built successfully, but the UI did not display the expected username.

Without debugging tools, I might have incorrectly assumed that the `UserName` value was missing or that the `DataContext` was not working.

The Watch and Immediate windows showed that the value was present at runtime. The XAML Binding Failures window then showed that the actual problem was the misspelled `UserNmae` binding.

This demonstrated how debugging tools can help separate data problems from UI binding problems.

## WPF Debugging Insights

WPF data-binding errors can occur at runtime even when the project compiles successfully.

For binding problems, checking the XAML Binding Failures window or Output window can provide useful diagnostic information.

For UI thread problems, it is important to remember that WPF controls normally need to be accessed from the UI thread. Breakpoints, the Call Stack, and thread-related debugger information can help identify where code is running and how execution reached a problematic UI update.

## Impact on Productivity

Improving my debugging skills can increase productivity because I can investigate problems systematically instead of changing code randomly.

By checking variables, application state, binding diagnostics, and execution flow, I can narrow down the cause of a bug faster.

This also reduces the risk of introducing unnecessary changes while trying to fix a problem.

## Additional Environment Observation

The project was initially created targeting:

```text
net10.0-windows
```

The installed command-line .NET 10 SDK successfully built the project, but my current Visual Studio 2022 version did not support targeting .NET 10.

For this debugging exercise, I changed only the `DebuggingDemo` project to:

```text
net9.0-windows
```

because .NET 9 was already installed and was supported by the current Visual Studio version. This allowed me to use Visual Studio's debugger without changing the broader repository setup.
