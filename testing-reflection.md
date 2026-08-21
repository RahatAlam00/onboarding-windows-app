<!-- cspell:ignore MVVM -->

# Unit Testing for WPF Applications Reflection

## Overview

For this task, I researched unit testing and UI testing approaches for WPF applications and created a small WPF project called `TestingDemo`.

The application contains a simple discount calculator. I separated the calculation logic from the UI so that the core functionality could be tested independently.

I also created a separate MSTest project called `TestingDemo.Tests` and wrote unit tests covering normal behaviour, boundary cases, and invalid input.

## Unit Testing vs UI Testing

Unit testing focuses on small pieces of application logic in isolation.

A unit test can directly create a class, call one of its methods, and verify that the result is correct without launching the WPF interface.

For example:

```text
Input:
Original price = 100
Discount = 10%

Expected result:
90
```

A UI test works at a higher level. It may launch the application, locate controls, simulate actions such as clicking buttons or entering text, and verify the visible result.

The main difference can be summarized as:

```text
Unit testing
- Tests individual logic
- Fast to execute
- Easier to isolate
- Usually more reliable
- Does not normally require the WPF window

UI testing
- Tests the application through the interface
- Slower
- Requires more setup
- Can verify interaction between several components
- Can be affected by timing, focus, layout, and control changes
```

Both types of testing are useful, but they solve different problems.

## Testing Frameworks and UI Automation Tools

Common unit testing frameworks for .NET applications include:

- MSTest
- NUnit
- xUnit

For this task, I chose MSTest.

The test project used:

```text
MSTest 4.0.2
```

MSTest uses attributes such as:

```csharp
[TestClass]
```

to identify test classes and:

```csharp
[TestMethod]
```

to identify individual test methods.

Assertions are then used to verify expected behaviour.

For WPF UI testing, Windows UI Automation can be used to locate and interact with visible UI elements programmatically.

UI automation tools can simulate actions such as:

```text
Find a control
        |
        v
Enter text
        |
        v
Click a button
        |
        v
Inspect resulting UI state
```

UI testing can provide confidence that the complete application works correctly, but it is usually more complex and slower than unit testing.

## Designing Testable WPF Code

One important design decision in this task was keeping the core calculation logic outside `MainWindow.xaml.cs`.

I created:

```text
TestingDemo/Services/DiscountCalculator.cs
```

The class contains:

```csharp
public decimal CalculateFinalPrice(
    decimal originalPrice,
    decimal discountPercentage)
```

The WPF window collects user input and displays the result, but the actual calculation is handled by `DiscountCalculator`.

This structure can be represented as:

```text
WPF View
   |
   v
MainWindow.xaml.cs
   |
   v
DiscountCalculator
   |
   v
Core calculation
```

The unit test project can directly test:

```text
DiscountCalculator
```

without launching the WPF window.

This makes the code easier to test and reduces dependencies between business logic and the user interface.

## Core Functionality

The calculator determines the final price after applying a percentage discount.

The basic calculation is:

```text
Discount amount
=
Original price × Discount percentage / 100

Final price
=
Original price - Discount amount
```

For example:

```text
Original price: 100
Discount: 10%

Discount amount: 10
Final price: 90
```

The WPF application was tested manually with:

```text
Original price: 100
Discount percentage: 10
```

The application displayed a final numeric value of:

```text
90
```

The exact currency symbol displayed depends on the Windows regional settings.

## Input Validation

The core class also validates invalid values.

A negative original price causes:

```csharp
ArgumentOutOfRangeException
```

A discount percentage below `0` or above `100` also causes:

```csharp
ArgumentOutOfRangeException
```

This allowed the unit tests to verify both successful calculations and invalid input handling.

## Unit Test Structure

The tests follow the general Arrange, Act, Assert approach.

```text
Arrange
Prepare input and objects

Act
Call the functionality being tested

Assert
Verify the result
```

For example:

```csharp
[TestMethod]
public void CalculateFinalPrice_WithTenPercentDiscount_ReturnsNinety()
{
    decimal result = _calculator.CalculateFinalPrice(100m, 10m);

    Assert.AreEqual(90m, result);
}
```

The test executes the calculation and verifies that the result is exactly `90`.

## Tests Implemented

I created six tests.

### Normal Discount

Input:

```text
Original price: 100
Discount: 10%
```

Expected result:

```text
90
```

### Zero Percent Discount

Input:

```text
Original price: 100
Discount: 0%
```

Expected result:

```text
100
```

This verifies the lower discount boundary.

### One Hundred Percent Discount

Input:

```text
Original price: 100
Discount: 100%
```

Expected result:

```text
0
```

This verifies the upper valid discount boundary.

### Negative Original Price

Input:

```text
Original price: -1
Discount: 10%
```

Expected result:

```text
ArgumentOutOfRangeException
```

### Negative Discount

Input:

```text
Original price: 100
Discount: -1%
```

Expected result:

```text
ArgumentOutOfRangeException
```

### Discount Above One Hundred Percent

Input:

```text
Original price: 100
Discount: 101%
```

Expected result:

```text
ArgumentOutOfRangeException
```

## Test Execution Evidence

I executed the test suite using:

```powershell
dotnet test TestingDemo.Tests/TestingDemo.Tests.csproj
```

Both projects built successfully.

The final test output was:

```text
Test summary: total: 6, failed: 0, succeeded: 6, skipped: 0
```

All six tests passed.

The test run completed successfully without requiring the WPF application window to open.

## Covering Critical Functionality and Edge Cases

This exercise showed that tests should not only cover the most common successful input.

The test suite includes:

```text
Normal behaviour
+
Lower boundary
+
Upper boundary
+
Invalid negative price
+
Invalid negative discount
+
Discount above valid range
```

Testing boundaries is important because many bugs occur at the edges of allowed input ranges.

For example, only testing a 10% discount would not prove that:

```text
0%
100%
-1%
101%
```

are handled correctly.

## How Testing Improves the Development Process

Tests provide a repeatable way to confirm that application behaviour remains correct.

Without automated tests, changes may require repeatedly testing features manually.

With tests, the workflow becomes:

```text
Change code
    |
    v
Run test suite
    |
    v
See whether existing behaviour still passes
```

This can detect regressions earlier and gives more confidence when refactoring or adding new functionality.

Tests can also encourage better software design.

In this exercise, placing the calculation inside a separate `DiscountCalculator` class made the code much easier to test than if all of the calculation logic had been written directly inside a WPF button event handler.

## Unit Test vs UI Test Trade-Offs

Unit tests are generally easier to create and maintain because they operate directly on code.

They are also fast and can run without displaying application windows.

However, a passing unit test does not prove that the entire UI behaves correctly.

For example, the `DiscountCalculator` tests can verify that:

```text
100 with 10% discount = 90
```

but they do not verify that:

```text
The user can enter 100
The user can enter 10
The Calculate button works
The correct value appears in the TextBlock
```

A UI test could verify these behaviours.

UI tests provide broader coverage but require more infrastructure and can be affected by factors such as:

- Control identifiers.
- Window timing.
- Focus.
- Animations.
- Changes in layout.
- Operating-system behaviour.

A useful strategy is therefore to have many fast unit tests for logic and fewer carefully selected UI tests for important user workflows.

## Challenges Specific to Testing WPF Applications

WPF applications can be more difficult to test when application logic is tightly coupled to controls and code-behind.

For example, code that directly accesses:

```text
TextBox
Button
TextBlock
Window
```

may require WPF infrastructure to be running before it can be tested.

One strategy is to separate application logic from the View.

Using patterns such as MVVM allows important functionality to live in:

```text
ViewModels
Services
Models
```

instead of directly inside the XAML code-behind.

These components can then be tested independently.

Other strategies include:

- Keeping business logic outside UI classes.
- Using dependency injection where appropriate.
- Using interfaces to replace external dependencies during testing.
- Using mocks or fakes for services.
- Testing ViewModels separately from Views.
- Limiting UI automation tests to important workflows.
- Giving UI elements stable automation identifiers where UI tests require them.

## Project Reference Issue Encountered

The WPF project initially targeted:

```text
net10.0-windows
```

while the automatically generated MSTest project targeted:

```text
net10.0
```

When I tried to reference the WPF project from the test project, .NET reported that the target frameworks were incompatible.

The test project could not reference the Windows-specific WPF project while targeting only `net10.0`.

I changed the test project target to:

```text
net10.0-windows
```

After this change, the project reference was added successfully:

```xml
<ProjectReference Include="..\TestingDemo\TestingDemo.csproj" />
```

This demonstrated that target-framework compatibility matters when connecting projects.

## Reflection

Implementing tests improves the development process because it creates an automated way to verify behaviour after code changes.

The most useful part of this exercise was seeing that core functionality becomes easier to test when it is separated from the UI.

The `DiscountCalculator` class could be tested directly without opening the WPF application.

Unit tests were straightforward to create and ran quickly. UI testing would provide more complete end-to-end confidence, but it would require more setup and would likely be more sensitive to changes in the interface.

For a larger WPF application, I would try to keep important application logic inside ViewModels or services and write unit tests for those components. I would then use a smaller number of UI automation tests for critical user workflows.

I would also include boundary cases and invalid input rather than testing only successful scenarios.

Improving my testing skills should help me identify bugs earlier, make refactoring safer, and reduce the amount of repetitive manual testing needed after code changes.

## Conclusion

This task demonstrated both the purpose of automated testing and the importance of designing WPF code so that it can be tested easily.

I created a WPF discount calculator, separated its core calculation into a `DiscountCalculator` service, created a separate MSTest project, connected the projects using a project reference, and wrote six unit tests covering normal behaviour, boundaries, and invalid inputs.

Running the test suite produced:

```text
6 total
6 succeeded
0 failed
0 skipped
```

The exercise showed that unit tests provide fast and reliable verification of core behaviour, while UI tests provide broader but more complex end-to-end coverage.
