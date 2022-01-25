using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGreet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter Username:");
            string Username=Console.ReadLine();
            Console.WriteLine("Hi!"+Username);
            Console.WriteLine("Welcome to the World C#");
        }
    }
}
