using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class RunnableAttribute : Attribute { }

public class TaskA
{
    [Runnable]
    public void DoTaskA()
    {
        Console.WriteLine("Task A is running...");
    }
}

public class TaskB
{
    [Runnable]
    public void DoTaskB()
    {
        Console.WriteLine("Task B is running...");
    }

    public void NotRunnable()
    {
        Console.WriteLine("This method is NOT marked runnable.");
    }
}

public class TaskC
{
    [Runnable]
    public void DoTaskC()
    {
        Console.WriteLine("Task C is running...");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var types = assembly.GetTypes();

        Console.WriteLine("Discovering [Runnable] methods...\n");

        foreach (var type in types)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

            foreach (var method in methods)
            {
                if (method.GetCustomAttributes(typeof(RunnableAttribute), false).Any())
                {
                    Console.WriteLine($"Invoking {type.Name}.{method.Name}()");
                    
                    var instance = Activator.CreateInstance(type);
                    method.Invoke(instance, null);
                    
                    Console.WriteLine(); 
                }
            }
        }

        Console.WriteLine("Done!");
    }
}
