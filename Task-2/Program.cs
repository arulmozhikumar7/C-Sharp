using System;

class Person
{
    // Properties
    public string Name { get; set; }

    // Constructor
    public Person(string name)
    {
        Name = name;
    }

    // Method to introduce the person
    public void Introduce()
    {
        Console.WriteLine($"Welcome {Name}!");
    }
}

class Program
{
    static void Main()
    {
        // Creating Person objects
        Person person1 = new Person("Arul");
        Person person2 = new Person("Ronaldo");

        // Calling Introduce method
        person1.Introduce();
        person2.Introduce();
    }
}
