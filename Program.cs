using System;
using System.Threading;

using static System.Console;
 

namespace minercaft_SMP_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "minecraft CMD (BETA)";
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            

            Console.Clear();

            // starts the func
            mainFunc();

            // makes sure it does not close
            Console.ReadKey();
        }

        static void mainFunc()
        {
            Console.Write(">>> ");

            string command = Convert.ToString(Console.ReadLine());

            switch (command)
            {
                case "close":
                Environment.Exit(0);
                    break;

                case "exit":
                    Environment.Exit(0);
                    break;
                
                default: 
                    WriteLine("ERROR!, could not execute command: " + command);
                    break;
            }

            

            mainFunc();
        }
    }
}
