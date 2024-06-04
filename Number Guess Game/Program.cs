using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Number_Guess_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Random num = new Random();
                int answer = num.Next(100);
                int no_of_guesses = 0;
                Console.WriteLine("Guess the Number");
                Console.WriteLine("Number is between 1 to 100");
                int user_input = Convert.ToInt32(Console.ReadLine());
                bool flag = true;
                while (flag)
                {
                    if (user_input == answer)
                    {
                        flag = false;
                        break;
                    }
                    else if (user_input > answer)
                    {
                        Console.WriteLine("Try a lesser number");
                    }
                    else
                    {
                        Console.WriteLine("Try a greater number");
                    }
                    user_input = Convert.ToInt32(Console.ReadLine());
                    no_of_guesses++;
                }

                Console.WriteLine("Success You've Guessed the nubmer right");
                Console.WriteLine("You've Guessed the number in " + no_of_guesses + " guesses");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Must enter an number");
                Console.WriteLine("Restart the application");
            }
                
        }
    }
}
