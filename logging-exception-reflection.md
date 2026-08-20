<!-- cspell:ignore Serilog NLog -->

# Logging & Exception Handling Reflection

## Overview

For this task, I researched logging and exception handling practices in C# and created a WPF application called `LoggingExceptionDemo`.

The practical exercise used Serilog as the logging framework. I implemented a deliberate file-loading failure, handled the resulting exception, logged useful diagnostic information, and displayed a user-friendly error message instead of allowing the application to crash.

## Logging Best Practices in C sharp

Logging provides information about what an application is doing while it runs. Effective logs can help developers understand application behaviour and investigate failures without relying only on reproducing a problem locally.

Common logging levels include:

- `Debug` for detailed diagnostic information.
- `Information` for normal application events.
- `Warning` for unexpected situations where the application can continue.
- `Error` for failed operations.
- `Fatal` for serious failures where the application cannot safely continue.

A good logging strategy should use the appropriate level instead of recording everything as an error.

Structured logging is also useful because contextual values can be represented as named properties. For example, in my application I used:

```csharp
Log.Information(
    "Attempting to load file {FilePath}",
    filePath);
```

Instead of manually joining the filename into the message, `{FilePath}` represents contextual information associated with the event.

Useful production logs should provide enough information to investigate an issue while avoiding sensitive information such as passwords, authentication tokens, or unnecessary personal data.

## Serilog

For this exercise, I chose Serilog.

I installed the following NuGet packages:

```text
Serilog              4.4.0
Serilog.Sinks.File   7.0.0
```

Serilog provides the logging functionality, while `Serilog.Sinks.File` allows the application to write log events to files.

I configured Serilog during application startup:

```csharp
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File(
        "logs/app-log.txt",
        rollingInterval: RollingInterval.Day)
    .CreateLogger();
```

I also logged application startup:

```csharp
Log.Information("Application started");
```

and application shutdown:

```csharp
Log.Information("Application closing");
```

Finally, I used:

```csharp
Log.CloseAndFlush();
```

during application exit so that pending log events are flushed before the application closes.

The file sink was configured with daily rolling, so the test produced a dated log file in the `logs` directory.

## Exception Handling Best Practices

Exceptions should be caught where the application can meaningfully handle them.

When the expected failure is known, catching a specific exception is preferable to catching every possible exception without considering its meaning.

For this exercise, the application deliberately attempted to read a file that did not exist:

```csharp
string content = File.ReadAllText(filePath);
```

I specifically handled:

```csharp
catch (FileNotFoundException ex)
```

rather than relying only on a general `catch (Exception)` block.

The exception was then logged using:

```csharp
Log.Error(
    ex,
    "Failed to load file {FilePath}",
    filePath);
```

Passing the exception object to the logger is important because it preserves useful diagnostic information such as the exception type and stack trace.

Exceptions should also not be silently swallowed. An empty `catch` block could hide a failure and make troubleshooting much more difficult.

## User-Facing Errors and Developer Diagnostics

The information shown to the user does not need to be the same as the information stored in the developer logs.

When the deliberate error occurred, the application displayed:

```text
The requested file could not be found. Please check the file and try again.
```

This was understandable to the user and did not expose an internal stack trace.

The log, however, contained much more technical information that would be useful to a developer.

This separation can be represented as:

```text
Operation fails
        |
        v
Exception is thrown
        |
        v
Specific exception is caught
       / \
      /   \
     v     v
Developer  User
log        message
     |       |
     v       v
Detailed   Simple and
diagnostic safe explanation
information
```

This allows the application to provide a better user experience while retaining the information needed for troubleshooting.

## Practical Implementation

The WPF application contained a button labelled:

```text
Load Missing File
```

When the button was clicked, the application attempted to read:

```text
missing-data.txt
```

The operation was structured as follows:

```text
User clicks Load Missing File
            |
            v
Log attempted operation
            |
            v
File.ReadAllText(...)
            |
            v
FileNotFoundException
            |
            v
Catch FileNotFoundException
           / \
          /   \
         v     v
  Log exception  Show friendly
  and context    UI message
```

The application therefore handled the expected failure instead of crashing.

## Logging Evidence

I ran the application and deliberately triggered the missing-file error.

Serilog created:

```text
logs/app-log20260820.txt
```

The log began with:

```text
2026-08-20 17:15:10.526 +10:00 [INF] Application started
```

When I clicked the button, the application recorded:

```text
2026-08-20 17:15:16.089 +10:00 [INF] Attempting to load file missing-data.txt
```

The failed operation was then recorded at the Error level:

```text
2026-08-20 17:15:16.091 +10:00 [ERR] Failed to load file missing-data.txt
```

The log identified the exception as:

```text
System.IO.FileNotFoundException
```

It also recorded that the missing file was:

```text
missing-data.txt
```

The stack trace showed that the exception reached my application code at:

```text
LoggingExceptionDemo.MainWindow.LoadFileButton_Click(...)
MainWindow.xaml.cs:line 36
```

Finally, when I closed the application, the log recorded:

```text
2026-08-20 17:15:26.739 +10:00 [INF] Application closing
```

This experiment demonstrated that the log provided substantially more diagnostic information than the user-facing message.

## Why Effective Logging Improves Troubleshooting

Effective logging can reduce the amount of time needed to investigate a failure.

For example, the log from this exercise immediately answered several useful questions:

```text
Did the application start successfully?
Yes.

What operation was attempted?
Loading missing-data.txt.

Did the operation fail?
Yes.

What type of failure occurred?
FileNotFoundException.

Where did the failure reach my code?
MainWindow.xaml.cs, line 36.

Did the application shut down normally?
Yes.
```

Without these logs, a developer might need to reproduce the issue manually before understanding what happened.

Logging can also improve code quality because repeated warnings and errors can reveal unreliable operations or areas that require better validation and error handling.

## Impact of Exception Handling on Stability and User Trust

Proper exception handling improves application stability because an expected failure does not necessarily need to terminate the entire application.

In my example, attempting to open a missing file could have resulted in an unhandled exception. Instead, the application caught the `FileNotFoundException`, recorded the failure, and informed the user that the requested file could not be found.

This provides a more controlled experience.

Users are more likely to trust an application that explains failures clearly and continues operating where possible than one that unexpectedly crashes or exposes technical stack traces.

At the same time, exception handling should not hide failures. Errors still need to be logged or otherwise surfaced to developers when appropriate.

## Production-Level Error Handling

A useful production pattern is:

```text
Expected recoverable failure
            |
            v
Catch specific exception
            |
            v
Log diagnostic context
            |
            v
Recover or show safe message
```

Unexpected errors may instead need to reach an appropriate higher-level exception handler where they can be logged and the application can fail safely.

Other useful practices include:

- Validate input before performing operations where possible.
- Catch specific exceptions when meaningful recovery is possible.
- Avoid empty `catch` blocks.
- Preserve exception details when logging.
- Avoid logging the same exception unnecessarily at several layers.
- Do not expose internal exception details directly to users.
- Clean up resources correctly after failures.
- Use retry logic only for operations where retrying is appropriate.

## Logging Strategies for a Complex Application

For a larger production application, I would extend the logging strategy beyond a single local file.

I would consider:

- Structured logging with consistent property names.
- Centralised log collection.
- Correlation identifiers to follow an operation across multiple components.
- Environment-specific log levels.
- Multiple sinks where appropriate.
- Log file rotation and retention policies.
- Monitoring and alerts for high-severity failures.
- Consistent logging conventions across the codebase.
- Redaction or exclusion of sensitive information.

For example, a correlation identifier could allow all log events related to one operation to be searched together even when that operation passes through several components.

## Runtime Log Files and Source Control

Running the application generated a file under:

```text
LoggingExceptionDemo/logs/
```

Runtime log files should not normally be committed to source control because they are generated application output, change frequently, and may contain machine-specific or sensitive diagnostic information.

I therefore added the following rule to the repository's `.gitignore`:

```gitignore
# Runtime log files
logs/
```

I then verified that Git ignored the generated log file.

The reflection documents the relevant observations from the test while the actual runtime log remains outside source control.

## Reflection

The most important lesson from this exercise was that logging and exception handling solve different but complementary problems.

Exception handling determines how the application responds when an operation fails. Logging preserves information that developers can later use to understand that failure.

The exercise also demonstrated why simply recording an exception message is often insufficient. Logging the exception object produced the exception type, message, file information, stack trace, and the location where the failure reached my application code.

I also saw the importance of separating developer diagnostics from user communication. The user received a short and understandable message, while the log retained detailed technical information.

In a more complex application, I would use structured logging consistently, centralise logs, include useful contextual identifiers, configure appropriate log levels for each environment, and ensure that sensitive information is not recorded.

Improving these skills should make troubleshooting faster because I can use recorded evidence to narrow down failures instead of relying on guesswork or repeatedly reproducing the problem.

## Conclusion

This task demonstrated how structured logging and exception handling can work together to improve application reliability and maintainability.

I integrated Serilog into a WPF application, configured a rolling file sink, logged normal application events, deliberately triggered a `FileNotFoundException`, caught the specific exception, logged it with contextual information, and displayed a safe user-facing error message.

The generated log confirmed that Serilog captured the operation, severity, exception type, missing file information, stack trace, application code location, and application lifecycle events.

The exercise showed how effective logging supports faster troubleshooting while appropriate exception handling helps applications respond to failures gracefully.
