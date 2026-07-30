# Exception Handling & Debugging Reflection

## Best practices for exception handling

- Catch only exceptions that can be handled.
- Catch specific exception types instead of the base Exception class whenever possible.
- Avoid using exceptions for normal program logic.
- Provide meaningful error messages.
- Log exceptions for troubleshooting.
- Use finally to clean up resources.
- Preserve the original stack trace when using `throw`; to throw the exception again.

---

## How try-catch-finally works

The `try` block contains code that might throw an exception.

If an exception occurs, execution moves to the matching `catch` block.

The `finally` block always executes, regardless of whether an exception occurred, making it suitable for cleanup.

---

## Debugging tools I used

- Breakpoints (F9)
- Step Over (F10)
- Step Into (F11)
- Continue (F5)
- Locals Window
- Watch Window
- Call Stack
- Exception Settings

---

## Reflection

### Reflect on a time when proper exception handling prevented a major issue

During this exercise, entering invalid input such as letters or zero would normally cause the application to crash. By handling `FormatException` and `DivideByZeroException`, the program continued running and displayed clear error messages instead of terminating unexpectedly.

### What debugging techniques did you find most effective

Using breakpoints together with Step Over allowed me to observe the program's execution line by line. Watching variables in the Locals and Watch windows made it easier to understand how the program behaved before and after an exception occurred.

### How can you improve error logging and reporting

Applications should record exceptions in log files or logging frameworks while presenting user-friendly error messages. Logging details such as the exception type, message, stack trace, and time of occurrence makes future debugging much easier while keeping the user experience professional.
