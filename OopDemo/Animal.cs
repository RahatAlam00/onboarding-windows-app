using System;

namespace OopDemo
{
    // Animal is an abstract parent class.
    // It provides common features for all animals.
    public abstract class Animal
    {
        // This property stores the animal's name.
        public string Name { get; private set; }

        // The constructor receives and stores the animal's name.
        protected Animal(string name)
        {
            Name = name;
        }

        // All animals can display their name in the same way.
        public void DisplayName()
        {
            Console.WriteLine($"Animal name: {Name}");
        }

        // Each child class must provide its own sound.
        public abstract void MakeSound();
    }
}