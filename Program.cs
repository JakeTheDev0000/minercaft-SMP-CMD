using System;
using System.Threading;

using static System.Console;
 

namespace minercaft_SMP_CMD
{
    class Program
    {
        static float version = 0.14f;
        static void Main(string[] args)
        {
            Title = $"minecraft CMD (BETA {version})";
            BackgroundColor = ConsoleColor.DarkBlue;
            

            Clear();

            // starts the func
            mainFunc();

            // makes sure it does not close
            ReadKey();
        }

        static void mainFunc()
        {
            Write(">>> ");

            string command = Convert.ToString(ReadLine());

            if(command == "help") {
                WriteLine("\"help\" gets this page");
                WriteLine("\"close\" or \"exit\" closes the console");
                WriteLine("\"cls\" clears the console");
                WriteLine("\"find\" enter the parameter at the end and it will give you cords");
                WriteLine();
                WriteLine("more info at \'https://github.com/JakeTheDev0000/minercaft-SMP-CMD\'");
            }

            if (command == "close" || command == "exit") {
                Environment.Exit(0);
            }

            if (command == "cls" || command == "clear") {
                Clear();
            }

            if(command.StartsWith("echo ")) {
                string text = command.Substring(5);
                WriteLine(text);
            }

            if(command.StartsWith("find ")) {
                string findText = command.Substring(5);

                if(findText == "base" || findText == "home") {
                    WriteLine("39 67 0");
                }
                else if(findText == "village1"){
                    WriteLine("42 68 191");
                }
                else if(findText == "village2"){
                    WriteLine("28 70 500");
                }
                else if(findText == "stronghold"){
                    WriteLine("599 37 654");
                }
                else if(findText == "portal"){
                    WriteLine("16 53 7 IN NETHER");
                }
                else if(findText == "blaze"){
                    WriteLine("-310 63 155 IN NETHER");
                }
                else
                {
                    WriteLine($"error, {findText} id not a valid place");
                    
                }
            }

            //else {WriteLine("error, can not execute command: "+ command);}

            

            mainFunc();
        }
    }
}
