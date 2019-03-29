using System;
using System.Threading;

namespace testConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there World!");
            Thread.Sleep(3000);
            Console.ReadLine();
        }
    }
}
