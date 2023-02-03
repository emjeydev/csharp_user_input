using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This file is made by EmJey
// Project: UserInput
// FileName: UserInput
// Date: 2023/02/01
// Email: emjeydev@gmail.com
// Github: emjeydev

namespace TestApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Enter your age: ");
            String age = Console.ReadLine();

            Console.WriteLine("Hello " + name + " You are " + age);

            Console.ReadLine(); 
        }
    }
}
