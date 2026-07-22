using System;

namespace OopDemo
{
    // Dog inherits common features from Animal.
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        // Dog provides its own implementation of MakeSound.
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
}