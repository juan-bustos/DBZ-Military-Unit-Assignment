using System;
using System.Threading;
namespace DBZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Thread.Sleep(2000);
            Console.WriteLine("Please press any key to create a Saiyan.");
            Console.ReadKey();
            Console.Clear();
            RunProgram SaiyanProgram = new RunProgram();
        }

    }
}
