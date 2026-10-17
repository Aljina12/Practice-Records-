    class Animal
    {
        public string Name = "Tommy";
        public string Sound = "Woof";

        public void MakeSound()
        {
            Console.WriteLine(Name + " says " + Sound);
        }
    }

        class Task15
    {
        public static void Run()
        {
            Animal animal = new Animal();
            animal.MakeSound();

            animal.Name = "Kitty";
            animal.Sound = "Meow";
            animal.MakeSound();
        }
    }

        class NumberChecker
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsPositive(int number)
        {
            return number > 0;
        }
    }

    
using System;

class Animal
{
    public string Name { get; set; } = "Animal";

    public void Eat()
    {
        Console.WriteLine($"{Name} is eating.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} is barking.");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog();

        dog.Name = "Buddy";

        dog.Eat();
        dog.Bark();
    }
}
