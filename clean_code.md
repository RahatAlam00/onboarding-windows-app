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



Efficiency means writing code that performs well and uses resources appropriately. However, efficiency should not lead to premature over-engineering. Code should first be correct and clear, then optimized when there is a real performance need.



---



# Messy Code Example



```csharp

public double calc(double p, int t, bool d)

{

&#x20;   double x = p;

&#x20;   if (d == true)

&#x20;   {

&#x20;       x = x - (x * 0.1);

&#x20;   }

&#x20;   double y = x * 0.1;

&#x20;   double z = x + y;

&#x20;   if (t > 0)

&#x20;   {

&#x20;       z = z + 5;

&#x20;   }

&#x20;   return z;

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

&#x20;   const double DiscountRate = 0.10;

&#x20;   const double TaxRate = 0.10;

&#x20;   const double DeliveryFee = 5.00;



&#x20;   double discountedPrice = basePrice;



&#x20;   if (hasDiscount)

&#x20;   {

&#x20;       discountedPrice -= discountedPrice * DiscountRate;

&#x20;   }



&#x20;   double taxAmount = discountedPrice * TaxRate;

&#x20;   double totalPrice = discountedPrice + taxAmount;



&#x20;   if (itemCount > 0)

&#x20;   {

&#x20;       totalPrice += DeliveryFee;

&#x20;   }



&#x20;   return totalPrice;

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



