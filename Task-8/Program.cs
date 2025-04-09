using System;
using System.Collections.Generic;
using System.Linq;

// Common entity interface
public interface IEntity
{
    int Id { get; set; }
}

// Sample entity
public class Student : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }

    public override string ToString() => $"Id: {Id}, Name: {Name}, Age: {Age}";
}

// Generic repository interface
public interface IRepository<T> where T : IEntity
{
    void Add(T item);
    T? Get(int id);
    IEnumerable<T> GetAll();
    void Update(T item);
    void Delete(int id);
}

// In-memory generic repository implementation
public class InMemoryRepository<T> : IRepository<T> where T : IEntity
{
    private readonly Dictionary<int, T> _storage = new();

    public void Add(T item)
    {
        if (_storage.ContainsKey(item.Id))
            throw new ArgumentException("Item with same ID already exists.");
        _storage[item.Id] = item;
    }

    public T? Get(int id)
    {
        _storage.TryGetValue(id, out T? item);
        return item;
    }

    public IEnumerable<T> GetAll() => _storage.Values;

    public void Update(T item)
    {
        if (!_storage.ContainsKey(item.Id))
            throw new KeyNotFoundException("Item not found.");
        _storage[item.Id] = item;
    }

    public void Delete(int id)
    {
        if (!_storage.Remove(id))
            throw new KeyNotFoundException("Item not found.");
    }
}

// Simple console UI
class Program
{
    static void Main()
    {
        IRepository<Student> studentRepo = new InMemoryRepository<Student>();

        while (true)
        {
            Console.WriteLine("\n--- Student Repository ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. List All Students");
            Console.WriteLine("6. Exit");
            Console.Write("Choose option: ");
            string? input = Console.ReadLine();

            try
            {
                switch (input)
                {
                    case "1":
                        var studentToAdd = ReadStudent();
                        studentRepo.Add(studentToAdd);
                        Console.WriteLine("Student added.");
                        break;

                    case "2":
                        Console.Write("Enter ID: ");
                        int idToGet = int.Parse(Console.ReadLine()!);
                        var student = studentRepo.Get(idToGet);
                        Console.WriteLine(student != null ? student : "Not found.");
                        break;

                    case "3":
                        var studentToUpdate = ReadStudent();
                        studentRepo.Update(studentToUpdate);
                        Console.WriteLine("Student updated.");
                        break;

                    case "4":
                        Console.Write("Enter ID: ");
                        int idToDelete = int.Parse(Console.ReadLine()!);
                        studentRepo.Delete(idToDelete);
                        Console.WriteLine("Student deleted.");
                        break;

                    case "5":
                        foreach (var s in studentRepo.GetAll())
                            Console.WriteLine(s);
                        break;

                    case "6":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }

    static Student ReadStudent()
    {
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Name: ");
        string name = Console.ReadLine()!;

        Console.Write("Enter Age: ");
        int age = int.Parse(Console.ReadLine()!);

        return new Student { Id = id, Name = name, Age = age };
    }
}
