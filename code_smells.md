# Identifying & Fixing Code Smells

## What Are Code Smells?

Code smells are warning signs in code that may indicate poor structure or design. A code smell does not always mean that the program is broken, but it can make the code more difficult to understand, maintain, test, or debug.

Refactoring code smells can improve code quality without changing the intended functionality of the program.

---

# 1. Magic Numbers & Strings

Magic numbers and strings are hardcoded values that appear in code without clearly explaining their meaning.

## Before Refactoring

```csharp
public double CalculateTotal(double price)
{
    return price + (price * 0.10);
}
```

The value `0.10` does not clearly explain what it represents.

## Refactored Version

```csharp
public double CalculateTotal(double price)
{
    const double TaxRate = 0.10;

    return price + (price * TaxRate);
}
```

Using the named constant `TaxRate` makes the purpose of the value clear and makes future changes easier.

---

# 2. Long Functions

Long functions often perform several responsibilities, making them difficult to read, test, and maintain.

## Before Refactoring

```csharp
public void ProcessOrder(double price, string customerEmail)
{
    double tax = price * 0.10;
    double totalPrice = price + tax;

    Console.WriteLine("Order total: " + totalPrice);
    Console.WriteLine("Saving order");

    Console.WriteLine("Sending confirmation to " + customerEmail);
}
```

The function calculates the total, displays information, saves the order, and handles a confirmation message.

## Refactored Version

```csharp
public void ProcessOrder(double price, string customerEmail)
{
    double totalPrice = CalculateTotal(price);

    DisplayOrderTotal(totalPrice);
    SaveOrder();
    SendConfirmation(customerEmail);
}

private double CalculateTotal(double price)
{
    const double TaxRate = 0.10;

    return price + (price * TaxRate);
}

private void DisplayOrderTotal(double totalPrice)
{
    Console.WriteLine("Order total: " + totalPrice);
}

private void SaveOrder()
{
    Console.WriteLine("Saving order");
}

private void SendConfirmation(string customerEmail)
{
    Console.WriteLine("Sending confirmation to " + customerEmail);
}
```

The responsibilities are now separated into smaller, focused functions.

---

# 3. Duplicate Code

Duplicate code occurs when the same logic is copied into multiple places.

## Before Refactoring

```csharp
public double CalculateFoodTotal(double price)
{
    return price + (price * 0.10);
}

public double CalculateClothingTotal(double price)
{
    return price + (price * 0.10);
}
```

The tax calculation is repeated in both functions.

## Refactored Version

```csharp
public double CalculateFoodTotal(double price)
{
    return AddTax(price);
}

public double CalculateClothingTotal(double price)
{
    return AddTax(price);
}

private double AddTax(double price)
{
    const double TaxRate = 0.10;

    return price + (price * TaxRate);
}
```

The repeated tax logic is now stored in one reusable function.

---

# 4. Large Classes (God Objects)

A large class or God Object handles too many unrelated responsibilities.

## Before Refactoring

```csharp
public class ApplicationManager
{
    public void SendEmail()
    {
        Console.WriteLine("Sending email");
    }

    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment");
    }

    public void UpdateInventory()
    {
        Console.WriteLine("Updating inventory");
    }

    public void GenerateReport()
    {
        Console.WriteLine("Generating report");
    }
}
```

The `ApplicationManager` class handles several unrelated parts of the application.

## Refactored Version

```csharp
public class EmailService
{
    public void SendEmail()
    {
        Console.WriteLine("Sending email");
    }
}

public class PaymentService
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing payment");
    }
}

public class InventoryService
{
    public void UpdateInventory()
    {
        Console.WriteLine("Updating inventory");
    }
}

public class ReportService
{
    public void GenerateReport()
    {
        Console.WriteLine("Generating report");
    }
}
```

Each class now has a clear and focused responsibility.

---

# 5. Deeply Nested Conditionals

Deeply nested conditional statements make the flow of code difficult to follow.

## Before Refactoring

```csharp
public void ProcessPurchase(User user)
{
    if (user != null)
    {
        if (user.IsActive)
        {
            if (user.Age >= 18)
            {
                if (user.HasMembership)
                {
                    CompletePurchase();
                }
            }
        }
    }
}
```

The multiple levels of nesting make the main logic difficult to reach and understand.

## Refactored Version

```csharp
public void ProcessPurchase(User user)
{
    if (user == null)
    {
        return;
    }

    if (!user.IsActive)
    {
        return;
    }

    if (user.Age < 18)
    {
        return;
    }

    if (!user.HasMembership)
    {
        return;
    }

    CompletePurchase();
}
```

Guard clauses remove unnecessary nesting and make the flow easier to follow.

---

# 6. Commented-Out Code

Commented-out code is old or unused code that remains inside the codebase as comments.

## Before Refactoring

```csharp
public void ProcessOrder()
{
    CalculateTotal();

    // ApplyOldDiscount();
    // SendOldConfirmation();
    // Console.WriteLine("Testing order");

    SaveOrder();
}
```

The commented-out code creates clutter and may confuse developers about whether the old code is still required.

## Refactored Version

```csharp
public void ProcessOrder()
{
    CalculateTotal();
    SaveOrder();
}
```

Unused code was removed. If an older implementation is needed later, it can be retrieved from Git version history.

---

# 7. Inconsistent Naming

Inconsistent or unclear naming makes code harder to understand.

## Before Refactoring

```csharp
string customerName;
double total_price;
bool HasDiscount;
int x;
```

The variables use different naming styles, and `x` does not describe its purpose.

## Refactored Version

```csharp
string customerName;
double totalPrice;
bool hasDiscount;
int itemCount;
```

The variables now follow a consistent naming style and clearly describe the data they contain.

---

# Reflection

## What Code Smells Did I Find in My Code?

The code examples contained several common code smells, including magic numbers, long functions, duplicate code, large classes, deeply nested conditionals, commented-out code, and inconsistent naming.

Some of these code smells were similar to problems I had already explored while learning clean code principles. This task helped me understand that these problems can be recognised as warning signs when reviewing code.

## How Did Refactoring Improve the Readability and Maintainability of the Code?

Refactoring made the code easier to understand by giving values meaningful names, separating responsibilities, removing duplicated logic, simplifying conditional statements, and using consistent naming.

The refactored code is also easier to maintain because important logic is separated into clear functions and classes. Future changes can be made in specific locations without needing to understand or modify unrelated parts of the code.

## How Can Avoiding Code Smells Make Future Debugging Easier?

Avoiding code smells makes debugging easier because the structure and responsibilities of the code are clearer.

When functions and classes have focused responsibilities, it is easier to identify where a problem may be occurring. Removing duplicate code also reduces the chance that the same bug exists in several places.

Clear naming and simpler conditional logic make it easier to follow the program's behaviour step by step. This allows developers to find and fix problems more efficiently.

## Personal Reflection

This task helped me understand that code can work correctly and still have quality problems. Code smells act as warning signs that code may become difficult to maintain as a project grows.

I also realised that many clean code principles are connected. Meaningful naming, small functions, the DRY principle, guard clauses, and removing unnecessary code can all help eliminate common code smells.

Learning to recognise these warning signs will help me review my own code more critically and think about how another developer would understand and maintain it in the future.