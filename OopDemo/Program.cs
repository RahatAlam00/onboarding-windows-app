using System;
using System.Collections.Generic;

namespace OopDemo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("C# Object-Oriented Programming Demo");
            Console.WriteLine();

            // The Factory pattern creates the animal objects.
            Animal dog = AnimalFactory.CreateAnimal("dog", "Buddy");
            Animal cat = AnimalFactory.CreateAnimal("cat", "Luna");

            // Both Dog and Cat objects are stored as Animal objects.
            List<Animal> animals = new List<Animal>
            {
                dog,
                cat
            };

            // The same method calls produce different behaviour.
            foreach (Animal animal in animals)
            {
                animal.DisplayName();
                animal.MakeSound();
                Console.WriteLine();
            }
        }
    }
}