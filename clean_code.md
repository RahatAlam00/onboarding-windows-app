# Clean Code Principles

## Simplicity

Simplicity means keeping code as straightforward as possible. Code should solve the problem without unnecessary complexity, clever tricks, or over-engineering. Simple code is easier to understand, test, debug, and modify.

## Readability

Readable code is code that another developer can understand without spending too much time figuring it out. Good naming, clear structure, proper formatting, and small functions all improve readability.

## Maintainability

Maintainable code is easy to update, fix, and extend in the future. This is important because software changes over time, and future developers (including the original developer) need to work with the code safely and confidently.

## Consistency

Consistency means following the same coding style, naming conventions, formatting rules, and project conventions throughout the codebase. Consistent code is easier to read because developers do not need to adjust to different styles in every file.

## Efficiency

Efficiency means writing code that performs well and uses resources appropriately. However, readability and correctness should come first, and code should only be optimized when there is a demonstrated performance need.

---

# Messy Code Example

```csharp
public double calc(double p, int t, bool d)
{
    double x = p;

    if (d == true)
    {
        x = x - (x * 0.1);
    }

    double y = x * 0.1;
    double z = x + y;

    if (t > 0)
    {
        z = z + 5;
    }

    return z;
}
```

## Why This Code Is Difficult to Read

This code is difficult to read because:

- The method name `calc` is vague.
- Variable names like `p`, `t`, `d`, `x`, `y`, and `z` do not explain their purpose.
- The values `0.1` and `5` are magic numbers that appear without explanation.
- The condition `d == true` is unnecessary.
- The method performs several operations without clearly describing the business logic.

A developer reading this code would need to guess what the method is calculating.

---

# Cleaner Version

```csharp
public double CalculateTotalPrice(double basePrice, int itemCount, bool hasDiscount)
{
    const double DiscountRate = 0.10;
    const double TaxRate = 0.10;
    const double DeliveryFee = 5.00;

    double discountedPrice = basePrice;

    if (hasDiscount)
    {
        discountedPrice -= discountedPrice * DiscountRate;
    }

    double taxAmount = discountedPrice * TaxRate;
    double totalPrice = discountedPrice + taxAmount;

    if (itemCount > 0)
    {
        totalPrice += DeliveryFee;
    }

    return totalPrice;
}
```

## Why This Version Is Cleaner

This version is cleaner because:

- The method name clearly explains what the function does.
- Variable names describe their purpose.
- Constants explain the meaning of fixed values.
- The condition `if (hasDiscount)` is easier to read than `if (d == true)`.
- The structure makes the calculation steps easier to follow.
- Future developers can update the discount rate, tax rate, or delivery fee more safely.

---

# Reflection

Clean code matters because software is usually maintained by teams, not just one person. Code that is simple, readable, maintainable, consistent, and efficient helps teams work faster, reduces bugs, and makes future changes easier.

---

# Naming Variables & Functions

## Best Practices for Naming Variables and Functions

Good variable and function names should clearly describe their purpose. A developer should be able to understand what a variable represents or what a function does without reading the implementation.

Some best practices include:

- Use descriptive and meaningful names.
- Use verbs for function names (e.g., `CalculateTotalPrice`, `ValidateInput`).
- Use nouns for variable names (e.g., `customerName`, `taxAmount`).
- Avoid single-letter names except for simple loop counters.
- Avoid unnecessary abbreviations.
- Follow the project's naming conventions consistently.
- Use names that describe the business meaning rather than the implementation.

---

## Example of Poor Naming

### Before Refactoring

```csharp
public bool chk(string s)
{
    if (s.Length < 8)
    {
        return false;
    }

    return true;
}
```

### Why This Code Is Difficult to Read

This code is difficult to understand because:

- The function name `chk` does not explain what it checks.
- The variable `s` gives no indication that it represents a password.
- A developer has to inspect the implementation to understand the function's purpose.

---

## Refactored Version

```csharp
public bool IsPasswordValid(string password)
{
    if (password.Length < 8)
    {
        return false;
    }

    return true;
}
```

### Improvements Made

The refactored version improves readability by:

- Renaming `chk` to `IsPasswordValid`, making the function's purpose immediately clear.
- Renaming `s` to `password`, making the parameter meaningful.
- Keeping the same logic while making the code much easier to understand.

---

# Reflection: Naming Variables & Functions

## What Makes a Good Variable or Function Name?

A good variable or function name is clear, descriptive, and meaningful. It should explain its purpose without requiring additional comments. Function names should usually describe an action using verbs, while variable names should describe the data they store using nouns. Consistent naming makes code easier to read and maintain.

## What Issues Can Arise from Poorly Named Variables?

Poorly named variables and functions make code difficult to understand, review, and maintain. Developers may misunderstand the purpose of the code, introduce bugs while making changes, or spend unnecessary time trying to understand what each variable represents. This increases cognitive load and slows down development.

## How Did Refactoring Improve Code Readability?

Refactoring improved readability by replacing vague names with descriptive ones that clearly communicate the purpose of the function and its parameter. A developer can now understand what the function does without reading its implementation. Clear naming reduces confusion, improves maintainability, and makes the code easier for other developers to understand.

---

# Code Formatting & Style Guides

## Why Is Code Formatting Important?

Code formatting is important because it makes code easier to read, understand, and maintain. When every developer follows the same style guide, the codebase becomes more consistent and easier to review. Consistent formatting also reduces unnecessary differences in commits and helps teams focus on the actual logic rather than spacing, indentation, or style disagreements.

Style guides also help teams avoid common problems by creating shared rules for naming, spacing, imports, semicolons, function structure, and other coding patterns.

## Airbnb JavaScript Style Guide

The Airbnb JavaScript Style Guide is a widely used style guide for JavaScript projects. It provides rules for writing consistent, readable, and maintainable JavaScript code.

Some examples of rules include:

- Prefer clear variable declarations.
- Avoid unnecessary loops when array methods can be used.
- Avoid `continue` when code can be structured more clearly.
- Avoid `await` inside loops unless there is a specific reason.
- Avoid unnecessary `console.log` statements in production code.
- Use consistent formatting and syntax.

## ESLint and Prettier Setup

I installed and configured ESLint and Prettier in the project.

I used:

```bash
npm init -y
npm install --save-dev eslint prettier eslint-config-airbnb-base eslint-plugin-import eslint-config-prettier
```

I created configuration files for ESLint and Prettier:

- `.eslintrc.json`
- `.prettierrc`

I then ran:

```bash
npx prettier . --write
npx eslint .
```
## What Issues Did the Linter Detect?

ESLint detected several style and code quality issues in duplicate-repo/duplicate-repo.js.

The main issues included:

Use of console statements.
Use of continue.
Use of await inside loops.
Use of for...of loops restricted by the Airbnb style guide.
Use of ++, which Airbnb discourages.
Suggestions to use object destructuring.
Warnings about constant conditions.

These issues do not necessarily mean the script is broken, because the script had already worked successfully for duplicating the repository issues and milestones. However, they show that the existing script does not fully follow the Airbnb JavaScript style guide.

## Did Formatting Make the Code Easier to Read?

Yes. Running Prettier made the code and Markdown files more consistently formatted. Consistent formatting makes the project easier to scan because spacing, indentation, quotes, and line breaks follow a predictable style.

The linter also helped identify areas where the JavaScript code could be improved for maintainability and consistency. Even when not all linter issues are fixed immediately, seeing the warnings helps developers understand which parts of the code may need refactoring later.

## Reflection: Code formatting and style guide

This task helped me understand that formatting tools and linters are useful because they automate consistency. Instead of relying only on developers to remember every style rule, tools like Prettier and ESLint can detect issues and guide improvements.

I also learned that formatting and linting are different. Prettier focuses mainly on formatting, while ESLint focuses more on code quality, style rules, and possible issues. Together, they help keep a codebase cleaner and easier for a team to maintain.

---

# Writing Small, Focused Functions

## Best Practices for Small Functions

Small functions should do one clear job. A function becomes easier to understand when it has a single responsibility and a clear name.

Best practices include:

- Keep each function focused on one purpose.
- Use clear function names that explain what the function does.
- Avoid mixing many responsibilities in one function.
- Break complex logic into helper functions.
- Make functions easier to test independently.
- Avoid very long functions that require too much scrolling or mental effort.

---

## Example of a Long Function

### Before Refactoring

```csharp
public void ProcessOrder(double price, bool hasDiscount, string customerEmail)
{
    double finalPrice = price;

    if (hasDiscount)
    {
        finalPrice = finalPrice - (finalPrice * 0.1);
    }

    double tax = finalPrice * 0.1;
    finalPrice = finalPrice + tax;

    Console.WriteLine("Order total: " + finalPrice);
    Console.WriteLine("Sending email to " + customerEmail);
}

```
## Why This Function Is Difficult to Maintain

This function is doing too many things at once:

- Calculating discount
- Calculating tax
- Printing the order total
- Sending or simulating an email notification

Because multiple responsibilities are mixed together, any future change requires modifying the same function. This increases complexity and makes the code harder to test, debug, and maintain.

### Refactored Version

```csharp

public void ProcessOrder(double price, bool hasDiscount, string customerEmail)
{
    double finalPrice = CalculateFinalPrice(price, hasDiscount);

    PrintOrderTotal(finalPrice);
    SendOrderConfirmation(customerEmail);
}

private double CalculateFinalPrice(double price, bool hasDiscount)
{
    double discountedPrice = ApplyDiscount(price, hasDiscount);
    double taxAmount = CalculateTax(discountedPrice);

    return discountedPrice + taxAmount;
}

private double ApplyDiscount(double price, bool hasDiscount)
{
    if (!hasDiscount)
    {
        return price;
    }

    return price - (price * 0.1);
}

private double CalculateTax(double price)
{
    return price * 0.1;
}

private void PrintOrderTotal(double totalPrice)
{
    Console.WriteLine("Order total: " + totalPrice);
}

private void SendOrderConfirmation(string customerEmail)
{
    Console.WriteLine("Sending email to " + customerEmail);
}

```
### Responsibilities of Each Function

- `ProcessOrder()` coordinates the overall workflow.
- `CalculateFinalPrice()` calculates the final amount after discount and tax.
- `ApplyDiscount()` applies the discount when eligible.
- `CalculateTax()` calculates the tax amount.
- `PrintOrderTotal()` displays the final order total.
- `SendOrderConfirmation()` handles the order confirmation message.

Each function now has a single responsibility, making the code easier to understand and maintain.

# Reflection: Writing Small, Focused Functions

## Why Is Breaking Down Functions Beneficial?

Breaking down functions is beneficial because each function becomes easier to understand, test, debug, and maintain. When a function does only one job, developers can understand its purpose quickly from the function name.

Small functions also reduce cognitive load. Instead of reading one long function and trying to understand everything at once, developers can follow the program step by step.

## How Did Refactoring Improve the Structure of the Code?

Refactoring improved the structure by separating the responsibilities into smaller functions. The main `ProcessOrder()` function now reads like a clear summary of the process, while the details are handled by helper functions.

This makes the code easier to modify in the future. For example, if the tax calculation changes, only the `CalculateTax()` function needs to be updated. If the email logic changes, only the `SendOrderConfirmation()` function needs to be updated.

---

# Avoiding Code Duplication

## DRY Principle

DRY stands for "Don't Repeat Yourself."

The main idea is that repeated logic should be written once and reused instead of being copied in multiple places. When the same code appears in many places, it becomes harder to maintain because any future change must be made in every repeated location.

---

## Example of Duplicated Code

### Before Refactoring

```csharp
public double CalculateRegularCustomerTotal(double price)
{
    double tax = price * 0.10;
    double total = price + tax;

    return total;
}

public double CalculatePremiumCustomerTotal(double price)
{
    double discount = price * 0.10;
    double discountedPrice = price - discount;

    double tax = discountedPrice * 0.10;
    double total = discountedPrice + tax;

    return total;
}

```

## What Were the Issues with Duplicated Code?

The tax calculation was repeated in both functions:

```csharp
double tax = price * 0.10;
double total = price + tax;
```

This duplication creates a maintenance problem. If the tax rate changes in the future, a developer must remember to update the tax calculation in multiple places. If one location is missed, the program may produce inconsistent results.

### Refactored Version

```csharp
public double CalculateRegularCustomerTotal(double price)
{
    return AddTax(price);
}

public double CalculatePremiumCustomerTotal(double price)
{
    double discountedPrice = ApplyDiscount(price);

    return AddTax(discountedPrice);
}

private double ApplyDiscount(double price)
{
    const double DiscountRate = 0.10;

    return price - (price * DiscountRate);
}

private double AddTax(double price)
{
    const double TaxRate = 0.10;

    return price + (price * TaxRate);
}
```
## How Did Refactoring Improve Maintainability?

Refactoring improved maintainability by moving the repeated tax calculation into one reusable function called `AddTax()`.

Now, if the tax rate changes, it only needs to be updated in one place. This reduces the risk of inconsistent behaviour and makes the code easier to update, test, and understand.

The refactored version also makes the code more readable because the function names clearly describe the business logic:

`ApplyDiscount()` handles discount calculation.
`AddTax()` handles tax calculation.
`CalculateRegularCustomerTotal()` and `CalculatePremiumCustomerTotal()` reuse those smaller functions.

# Reflection: Avoiding Code Duplication

Duplicated code may seem harmless at first, but it becomes risky as the project grows. Repeated logic increases the chance of bugs because developers may update one copy of the code but forget another.

The DRY principle helps keep code cleaner by encouraging reusable functions. This makes future changes safer and easier because important logic exists in one place instead of being scattered throughout the codebase.

---

# Refactoring Code for Simplicity

## Common Refactoring Techniques

Refactoring is the process of improving the structure of existing code without changing its behaviour.

Some common refactoring techniques include:

- Simplifying complex conditional statements.
- Breaking large functions into smaller functions.
- Removing unnecessary variables.
- Eliminating duplicated code.
- Replacing magic numbers with named constants.
- Using meaningful variable and function names.
- Removing unnecessary nesting.

---

## Example of Overly Complicated Code

### Before Refactoring

```csharp
public bool CanPurchase(int age, bool hasMembership)
{
    bool result = false;

    if (age >= 18)
    {
        if (hasMembership == true)
        {
            result = true;
        }
        else
        {
            result = false;
        }
    }
    else
    {
        result = false;
    }

    return result;
}
```

## What Made This Code Complex?

Although the function is small, it contains unnecessary complexity:

- Multiple nested `if` statements.
- A temporary variable (`result`) that is not needed.
- Repeated assignments of `true` and `false`.
- More lines of code than necessary for a simple decision.

The business logic is simple, but the implementation makes it look more complicated than it is.

---

## Refactored Version

```csharp
public bool CanPurchase(int age, bool hasMembership)
{
    return age >= 18 && hasMembership;
}
```

## Why Is This Version Simpler?

The refactored version:

- Removes unnecessary nesting.
- Eliminates the temporary variable.
- Returns the result directly.
- Expresses the business rule in a single, easy-to-read statement.

The behaviour of the function remains exactly the same.

---

# Reflection: Refactoring Code for Simplicity

## What Made the Original Code Complex?

The original code used several unnecessary `if` statements and a temporary variable to perform a simple check. This made the function longer than necessary and required more effort to understand.

## How Did Refactoring Improve It?

Refactoring simplified the function by expressing the business rule directly. The code became shorter, easier to read, and easier to maintain without changing its behaviour.

This task taught me that simple code is often better than clever or overly detailed code. Removing unnecessary complexity makes software easier for both the original developer and future team members to understand.

---

# Commenting & Documentation

## Best Practices for Comments and Documentation

Comments should provide useful information that is not immediately obvious from the code itself. Good comments help developers understand why a decision was made, explain unusual behaviour, or provide important context.

Best practices include:

* Explain why the code exists rather than repeating what the code does.
* Keep comments clear and concise.
* Add comments when business rules or technical decisions are not obvious.
* Document important limitations or unexpected behaviour.
* Keep comments updated when the code changes.
* Use clear variable and function names so unnecessary comments are avoided.
* Avoid commenting every line of code.

---

## Example of Poorly Commented Code

### Before Refactoring

```csharp
public double CalculatePrice(double price)
{
    // Create tax variable
    double tax = price * 0.10;

    // Add tax to price
    price = price + tax;

    // Check if price is greater than 100
    if (price > 100)
    {
        // Subtract 5 from price
        price = price - 5;
    }

    // Return price
    return price;
}
```

## Why Are These Comments Poor?

The comments simply repeat what the code already says.

For example:

```csharp
// Return price
return price;
```

A developer can already understand that `return price` returns the price. The comment does not provide any additional information.

These unnecessary comments make the code longer and create more text for developers to read without improving their understanding.

---

## Improved Version

```csharp
public double CalculatePrice(double price)
{
    const double TaxRate = 0.10;
    const double HighValueOrderThreshold = 100;
    const double HighValueOrderDiscount = 5;

    double priceWithTax = price + (price * TaxRate);

    // Orders above the threshold receive a fixed discount as part of the
    // company's high-value order incentive.
    if (priceWithTax > HighValueOrderThreshold)
    {
        priceWithTax -= HighValueOrderDiscount;
    }

    return priceWithTax;
}
```

## How Were the Comments Improved?

The unnecessary comments were removed because clear variable and constant names already explain what the code is doing.

The remaining comment explains why orders above the threshold receive a discount. This business reason is not obvious from the code itself, so the comment provides useful context for future developers.

---

# Reflection: Commenting & Documentation

## When Should You Add Comments?

Comments should be added when they provide important context that cannot be understood easily from the code alone.

Useful comments can explain:

* Why a particular technical decision was made.
* Complex business rules.
* Unexpected behaviour or limitations.
* Workarounds for external systems or known issues.
* Important information that future developers need to understand.

A good comment should help answer the question: "Why was the code written this way?"

## When Should You Avoid Comments and Instead Improve the Code?

Comments should be avoided when they simply describe what the code already does.

If code requires comments because variable names, function names, or logic are difficult to understand, the code should first be refactored to make it clearer.

For example, instead of using a vague variable such as `x` and adding a comment to explain it, the variable should be renamed to something meaningful such as `totalPrice`.

This task helped me understand that comments should not compensate for unclear code. Clean and readable code should explain what it does, while useful comments should provide additional context about why a particular decision or behaviour exists.

---

# Handling Errors & Edge Cases

## Strategies for Handling Errors and Edge Cases

Error handling helps software respond safely when something unexpected happens. Edge cases are unusual or extreme inputs that may not occur often but can still cause incorrect behaviour or program failures.

Some common strategies for handling errors and edge cases include:

* Validating input before processing it.
* Using guard clauses to reject invalid input early.
* Using exceptions when a function cannot continue safely.
* Checking for `null` or missing values.
* Handling empty strings and empty collections.
* Considering zero and negative numbers when working with calculations.
* Providing clear error messages.
* Logging errors when appropriate.
* Avoiding silent failures where the program ignores a problem without explaining it.

---

## Guard Clauses

A guard clause checks for invalid conditions at the beginning of a function and stops execution early if a requirement is not met.

Guard clauses help keep the main logic simple and prevent invalid data from continuing through the function.

For example:

```csharp
if (itemCount <= 0)
{
    throw new ArgumentException("Item count must be greater than zero.");
}
```

This checks the input before performing the calculation.

---

## Example Without Proper Error Handling

### Before Refactoring

```csharp
public double CalculatePricePerItem(double totalPrice, int itemCount)
{
    return totalPrice / itemCount;
}
```

## What Was the Issue with the Original Code?

The original function assumes that `totalPrice` and `itemCount` will always contain valid values.

However, several edge cases are not handled:

* `itemCount` could be zero.
* `itemCount` could be negative.
* `totalPrice` could be negative.

A zero item count would result in an invalid calculation, while negative values do not make sense in this order calculation.

The function does not validate its inputs before using them.

---

## Refactored Version with Guard Clauses

```csharp
public double CalculatePricePerItem(double totalPrice, int itemCount)
{
    if (totalPrice < 0)
    {
        throw new ArgumentOutOfRangeException(
            nameof(totalPrice),
            "Total price cannot be negative."
        );
    }

    if (itemCount <= 0)
    {
        throw new ArgumentOutOfRangeException(
            nameof(itemCount),
            "Item count must be greater than zero."
        );
    }

    return totalPrice / itemCount;
}
```

## How Did the Refactoring Improve Error Handling?

The refactored function uses guard clauses to validate the input before performing the calculation.

The first guard clause prevents a negative total price from being processed.

The second guard clause prevents zero or negative item counts.

If invalid data is provided, the function stops immediately and throws an exception with a clear message. The main calculation only runs after the inputs have passed the validation checks.

---

# Reflection: Handling Errors & Edge Cases

## What Was the Issue with the Original Code?

The original function assumed that all inputs would be valid. It did not check for zero, negative values, or other invalid inputs before performing the calculation.

This could lead to invalid results or unexpected behaviour. The function was therefore not reliable when receiving unexpected input.

## How Does Handling Errors Improve Reliability?

Handling errors improves reliability because the program can identify invalid conditions before they cause larger problems.

Guard clauses prevent invalid data from reaching the main logic of a function. Clear exceptions also help developers understand what went wrong and where the problem occurred.

This makes software easier to debug, safer to maintain, and more predictable for both developers and users.

This task helped me understand that writing code is not only about making it work with normal inputs. Developers also need to think about edge cases by asking questions such as "What if the value is zero?", "What if the value is negative?", or "What if required data is missing?"
