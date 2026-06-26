# Clean Code Principles



## Simplicity



Simplicity means keeping code as straightforward as possible. Code should solve the problem without unnecessary complexity, clever tricks, or over-engineering. Simple code is easier to understand, test, debug, and modify.



## Readability



Readable code is code that another developer can understand without spending too much time figuring it out. Good naming, clear structure, proper formatting, and small functions all improve readability.



## Maintainability



Maintainable code is easy to update, fix, and extend in the future. This is important because software changes over time, and future developers, including the original developer, need to work with the code safely and confidently.



## Consistency



Consistency means following the same coding style, naming conventions, formatting rules, and project patterns throughout the codebase. Consistent code is easier to read because developers do not need to adjust to different styles in every file.



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



* The method name `calc` is vague.

* Variable names like `p`, `t`, `d`, `x`, `y`, and `z` do not explain their purpose.

* The value '0.1', '5' appears without explanation.

* The condition `d == true` is unnecessary.

* The method does several things without clearly describing the business logic.



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



* The method name clearly explains what the function does.

* Variable names describe their purpose.

* Constants explain the meaning of fixed values.

* The condition `if (hasDiscount)` is easier to read than `if (d == true)`.

* The structure makes the calculation steps easier to follow.

* Future developers can update discount, tax, or delivery fee values more safely.



---



# Reflection



Clean code matters because software is usually maintained by teams, not just one person. Code that is simple, readable, maintainable, consistent, and efficient helps teams work faster, reduces bugs, and makes future changes easier.

## 📌 Reflection: Naming Variables & Functions

### 1. What makes a good variable or function name?
A good name is intent-revealing; it should tell the reader exactly why it exists and what it represents without needing a comment. It should be descriptive but not wordy, using nouns for variables (e.g., `userEmailAddress`) and verbs for functions (e.g., `saveUserProfile`). Good names also follow consistent casing (like camelCase or PascalCase) and are easy to pronounce, making the code easier to discuss with a team.

### 2. What issues can arise from poorly named variables?
Poorly named variables (like `a`, `data`, or `temp`) lead to "mental mapping," where a developer has to constantly remember what each letter stands for. This causes confusion, increases the likelihood of bugs during maintenance, and makes it nearly impossible for a new developer to join the project and understand the logic quickly. It turns simple code into a puzzle that wastes time.

### 3. How did refactoring improve code readability?
Refactoring the messy code replaced vague identifiers (like `p` and `d`) with meaningful terms (`basePrice` and `hasDiscount`). By using constants like `TaxRate` instead of "magic numbers" like `0.1`, the logic becomes self-documenting. A developer can now read the code like a sentence and understand the business rules (calculating a total with tax and a potential discount) instantly, rather than having to dry-run the math in their head to figure out what is happening.

