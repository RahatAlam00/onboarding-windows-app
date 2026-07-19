# C# Syntax & Data Types Reflection

## Which aspects of C# syntax were new or surprising?

One aspect of C# syntax that was new to me was the use of string interpolation (`$""`). It provides a much cleaner and more readable way to combine text and variables compared to traditional string concatenation. I was also surprised by how easy it is to declare constants using the `const` keyword, ensuring that values which should never change are protected by the compiler.

## How do data types influence performance and memory management in your code?

Different data types use different amounts of memory. Choosing an appropriate data type helps reduce memory usage and can improve performance. For example, an `int` uses less memory than a `double`, while a `bool` only stores a true or false value.

## What practices can help avoid common type-related errors?

Good practices include using the correct data type for each value, avoiding unnecessary type conversions, using explicit casting only when needed, and using methods such as `int.TryParse()` to safely convert user input instead of allowing exceptions to occur.

## Personal Reflection

This task helped me understand the basic building blocks of C# programming. I learned how variables, constants, operators, and type conversions work together, and I now have a better understanding of how C# manages different kinds of data.

## Type Conversion Observations

I experimented with converting a string (`"100"`) into an integer using `Convert.ToInt32()`. The conversion succeeded because the string contained a valid numeric value.

If a string contains non-numeric text (for example `"abc"`), `Convert.ToInt32()` throws a `FormatException`. In real applications, using `int.TryParse()` is a safer approach because it prevents the program from crashing when invalid input is entered.
