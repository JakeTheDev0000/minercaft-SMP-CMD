using System;
using System.Threading;

namespace minercaft_SMP_CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            mainFunc();

            // makes sure it does not close
            Console.ReadKey();
        }

        static void mainFunc()
        {
            Console.Write("testyt");

            Thread.Sleep(1000);

            mainFunc();
        }
    }
}
