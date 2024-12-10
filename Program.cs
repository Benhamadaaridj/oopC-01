using System;


class Program
{
    static void Main(string[] args)
    {
        
        Animal animal = new Animal(" Animal", "Unknown ", 2);

        Dog dog = new Dog("GB", "husky", 3, "Ball");

        
        animal.Bark();
        dog.Bark();

        
        Console.WriteLine($"Animal Name: {animal.GetName()}");
        Console.WriteLine($"Animal Breed: {animal.Getbreed()}");
        Console.WriteLine($"Animal Age: {animal.GetAge()}");

        Console.WriteLine($"Dog Name: {dog.GetName()}");
        Console.WriteLine($"Dog Breed: {dog.Getbreed()}");
        Console.WriteLine($"Dog Age: {dog.GetAge()}");
        Console.WriteLine($"Dog Favorite Toy: {dog.GetfavoriteToy()}");
    }
}