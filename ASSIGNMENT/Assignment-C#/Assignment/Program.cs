// See https://aka.ms/new-console-template for more information
using System;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Your Age :");
            int age = int.Parse(Console.ReadLine());

            MyClass objClass;
            objClass = new MyClass();
            objClass.ID = age;


        }
    }
}

