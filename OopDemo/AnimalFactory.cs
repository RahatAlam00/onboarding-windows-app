using System;

namespace OopDemo
{
    // The Factory class creates animal objects.
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string animalType, string name)
        {
            switch (animalType.ToLower())
            {
                case "dog":
                    return new Dog(name);

                case "cat":
                    return new Cat(name);

                default:
                    throw new ArgumentException(
                        $"The animal type '{animalType}' is not supported."
                    );
            }
        }
    }
}