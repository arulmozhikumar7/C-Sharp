using System;
using System.Collections.Generic;


namespace To_do
{
    internal class Program
    {
        class TODO
        {
            public String Description { get; set; }
            public bool IsCompleted { get; set; }
            public TODO(string description)
            {
                Description = description;
                IsCompleted = false;
            }

            public override String ToString()
            {
                return $"{Description} - {(IsCompleted ? "Completed" : "Pending")}";
            }

        }
        static List<TODO> list = new List<TODO>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("TO-DO APPLICATION");
                Console.WriteLine("=================");
                Console.WriteLine("1.Add a new task");
                Console.WriteLine("2.View all tasks");
                Console.WriteLine("3.Update task status");
                Console.WriteLine("4.Update task description");
                Console.WriteLine("5.Delete a task");
                Console.WriteLine("6.Exit");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddToDoItem();
                        break;
                    case "2":
                        ViewToDoItems();
                        break;
                    case "3":
                        UpdateToDoStatus();
                        break;
                    case "4":
                        UpdateToDoDescription();
                        break;
                    case "5":
                        DeleteToDo();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid Option. Please Try Again");
                        break;
                }
            }

        }

        static void AddToDoItem()
        {
            Console.Clear();
            Console.WriteLine("Enter the description of the new task");
            var description = Console.ReadLine();
            list.Add(new TODO(description));
            Console.WriteLine("Task added Successfully. Press any key to return to main menu");
            Console.ReadKey();
        }

        static void ViewToDoItems()
        {
            Console.Clear();
            Console.WriteLine("TO-DO LIST:");
            Console.WriteLine("===========");
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {list[i]}");
                }
            }
            else
            {
                Console.WriteLine("No Todo items");
            }

            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadKey();
        }

        static void UpdateToDoStatus()
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("No todo items available");
            }
            else
            {
                Console.WriteLine("To-do Items:");
                Console.WriteLine("============");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{list[i]}");
                }
                Console.WriteLine("Enter the number of todo to update the status");
                if (int.TryParse(Console.ReadLine(), out int index) && index>0 && index <=list.Count ){
                    list[index-1].IsCompleted = true;
                    Console.WriteLine("Item marked as Completed");
                }
                else
                {
                    Console.WriteLine("Invalid number . Please Try Again");
                }
            }
            Console.WriteLine("Enter any key to return to Main Menu");
            Console.ReadKey();
        }

        static  void DeleteToDo()
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("No todo items available");
            }
            else
            {
                Console.WriteLine("To-do Items:");
                Console.WriteLine("============");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{list[i]}");
                }
                Console.WriteLine("Enter the number of todo to be deleted");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= list.Count)
                {
                    list.RemoveAt(index-1);
                    Console.WriteLine("Item deleted successfully");
                }
                else
                {
                    Console.WriteLine("Invalid number . Please Try Again");
                }
            }
            Console.WriteLine("Enter any key to return to Main Menu");
            Console.ReadKey();
        }


        static void UpdateToDoDescription()
        {
            Console.Clear();
            if (list.Count == 0)
            {
                Console.WriteLine("No todo items available");
            }
            else
            {
                Console.WriteLine("To-do Items:");
                Console.WriteLine("============");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{i + 1}.{list[i]}");
                }
                Console.WriteLine("Enter the number of todo to update the description");
                if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= list.Count)
                {
                    Console.WriteLine("Enter new description : ");
                    var new_description = Console.ReadLine();
                    list[index - 1].Description = new_description;
                    Console.WriteLine("Description Updated as Completed");
                }
                else
                {
                    Console.WriteLine("Invalid number . Please Try Again");
                }
            }
            Console.WriteLine("Enter any key to return to Main Menu");
            Console.ReadKey();
        }
    }
}
