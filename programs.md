using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BgColor_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.WriteLine("Enter A Name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter A Age:");
            String ag = Console.ReadLine();
            Console.WriteLine("Name : " + name + "   " +  "Age : " + ag);
            Console.Read();
        }
    }
}
