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

## Reflection

This task helped me understand that formatting tools and linters are useful because they automate consistency. Instead of relying only on developers to remember every style rule, tools like Prettier and ESLint can detect issues and guide improvements.

I also learned that formatting and linting are different. Prettier focuses mainly on formatting, while ESLint focuses more on code quality, style rules, and possible issues. Together, they help keep a codebase cleaner and easier for a team to maintain.