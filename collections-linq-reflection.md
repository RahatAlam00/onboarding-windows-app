# Collections & LINQ Reflection

<!-- cspell:ignore LINQ -->

## What are the common collection types in C#?

Common collection types in C# include arrays, lists, dictionaries,
hash sets, queues, and stacks.

An array stores a fixed number of values of the same type. A `List<T>`
also stores ordered values, but it can grow or shrink as items are added
or removed.

A `Dictionary<TKey, TValue>` stores key-value pairs and is useful when
data must be retrieved using a unique key. A `HashSet<T>` stores unique
values and prevents duplicates.

A queue follows first-in, first-out processing, while a stack follows
last-in, first-out processing.

## How does LINQ simplify data queries?

LINQ provides methods for filtering, sorting, grouping, selecting, and
calculating values in collections. It often replaces longer loops and
conditional statements with shorter expressions that clearly describe
the desired result.

In this task, I used `Where()` to select students who scored at least
80 and `OrderByDescending()` to arrange them from the highest score to
the lowest score.

Without LINQ, I would need to create another list, loop through every
student, test each score with an `if` statement, add matching students,
and then sort the result separately.

## What are some performance considerations when choosing a collection?

The appropriate collection depends on how the data will be used. An
array is useful when the number of items is fixed, while a `List<T>` is
more appropriate when items must be added or removed.

A dictionary is suitable when values must be retrieved frequently using
unique keys. A list may require searching through several items to find
a particular value.

Sorting and repeatedly executing LINQ queries can require additional
processing. Query results can be stored in a list when the same results
will be used multiple times.

## Which collection type is most useful for different scenarios?

I find `List<T>` most useful for general ordered data because it is easy
to add, remove, access, and loop through items. It is suitable for lists
of users, tasks, products, or records.

A dictionary is more useful when every value has a unique key. For
example, it can store student names and scores, product identifiers and
products, or configuration names and values.

A hash set would be useful when duplicate items must be prevented.

## How does LINQ improve code readability and efficiency?

LINQ improves readability because methods such as `Where()`,
`OrderByDescending()`, and `Average()` clearly describe what the code is
trying to achieve.

It reduces the amount of manual looping and conditional logic required.
This can make the code shorter and easier to maintain. LINQ does not
automatically make every operation faster, so it is still important to
avoid unnecessary repeated queries.

## Reflect on a situation where LINQ could simplify code

A student-management program may need to display only students who have
passed and arrange them by score.

Without LINQ, the program would need a loop, an `if` condition, a second
collection, and separate sorting logic. With LINQ, filtering and sorting
can be expressed in one query.

In this task, the following query selected students with scores of at
least 80 and sorted them from highest to lowest:

```csharp
List<Student> highScoringStudents = students
    .Where(student => student.Score >= 80)
    .OrderByDescending(student => student.Score)
    .ToList();
```

This made the intention of the code easier to understand.

## Findings from the Programming Task

I used a `List<Student>` to store an ordered and resizable collection of
student objects. Each student also contained a
`Dictionary<string, int>` that connected subject names with marks.

I used LINQ to filter and sort the student list and to calculate the
average score. This showed me that different collection types solve
different storage problems, while LINQ provides a simple and readable
way to query and manipulate data.
