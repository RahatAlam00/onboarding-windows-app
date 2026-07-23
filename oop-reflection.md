# Object-Oriented Programming in C# Reflection

## What are the four main pillars of OOP in C#?

The four main pillars of object-oriented programming are encapsulation, inheritance, polymorphism, and abstraction.

Encapsulation involves keeping an object's data and behaviour together while controlling how its internal data can be accessed or modified. In C#, this can be achieved using classes, properties, and access modifiers such as `public`, `private`, and `protected`.

Inheritance allows one class to reuse and extend the members of another class. In this task, the `Dog` and `Cat` classes inherit common features from the `Animal` class.

Polymorphism allows objects from different classes to be treated through a shared parent type while still providing their own behaviour. For example, both `Dog` and `Cat` are treated as `Animal` objects, but each class produces a different result when `MakeSound()` is called.

Abstraction involves exposing the important features of an object while hiding unnecessary implementation details. The abstract `Animal` class defines the common behaviour that every animal must provide without defining one universal animal sound.

## How do inheritance, polymorphism, and encapsulation appear in the code?

Inheritance appears when the `Dog` and `Cat` classes inherit from the `Animal` class. This allows both child classes to reuse the `Name` property and the `DisplayName()` method.

Polymorphism appears when `Dog` and `Cat` objects are stored in a collection of `Animal` objects. The program calls the same `MakeSound()` method for each animal, but the result depends on the actual object.

Encapsulation appears in the `Name` property. The property has a public getter and a private setter, allowing other classes to read the value without changing it directly.

## Which design patterns leverage OOP principles to improve code structure?

Several design patterns use OOP principles, including Factory, Singleton, Strategy, Observer, and Repository.

For this task, I implemented the Factory pattern. The `AnimalFactory` class creates the requested animal object based on an animal type. This keeps object-creation logic in one place and prevents the main program from depending directly on every child class.

## Which OOP principle did you find most challenging and why?

I found polymorphism the most challenging principle because a variable can be declared using a parent type while holding an object created from a child class. At first, it was not obvious how calling the same method could produce different results. The example helped me understand that C# selects the overridden method based on the actual object at runtime.

## How does applying OOP enhance code reusability and maintainability?

OOP improves reusability by allowing common data and behaviour to be placed in a parent class instead of being repeated in every child class. In this example, the `Name` property and `DisplayName()` method are written once in the `Animal` class and reused by both `Dog` and `Cat`.

It also improves maintainability because each class has a clear responsibility. Changes to one animal's behaviour can be made inside its own class without affecting the other animal classes.

## Reflect on a scenario where using OOP made a project easier to manage

While building this task, I found that using an `Animal` parent class made the project easier to manage. Once I had implemented the shared behaviour in the parent class, adding the `Dog` and `Cat` classes required much less code. If I wanted to add another animal in the future, I could create a new class and reuse the existing program structure without changing the main processing logic.

Without OOP, the program might require separate variables, duplicated code, and multiple conditional statements for every animal type. With inheritance and polymorphism, a new animal class can be added without rewriting the main processing logic.

## Factory Pattern Reflection

The Factory pattern separates object creation from object usage. Instead of creating `Dog` and `Cat` objects directly in the main program, the program asks `AnimalFactory` to create the requested object.

This approach makes the code more organised and easier to extend. For example, a new `Bird` class could be added by creating the class and adding another option to the factory without changing the way the rest of the program processes animals.
