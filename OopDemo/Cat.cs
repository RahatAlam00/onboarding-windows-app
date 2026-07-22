using System;

namespace OopDemo
{
    // Cat also inherits common features from Animal.
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        // Cat provides a different implementation of MakeSound.
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}