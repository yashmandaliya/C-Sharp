//Program To Change Background Color 
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


Output 

![first](https://user-images.githubusercontent.com/112624754/215940665-251ba994-66a7-43df-bb52-57d5520a3256.png)
