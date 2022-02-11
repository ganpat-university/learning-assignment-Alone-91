using System;

namespace Demo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Pass By Value :");
            i = 20;
            Console.WriteLine("i : {0}", i);
            PassByValue(i);
            Console.WriteLine(" after replace i : {0}", i);
            Console.WriteLine();

            Console.WriteLine("Pass By Reference");
            i = 20;
            Console.WriteLine("i = {0}", i);
            PassByReference(ref i);
            Console.WriteLine("i now = {0}", i);
        }

        static void PassByValue(int a)
        {
            Console.WriteLine("Received a = {0}", a);
            a = 30;
            Console.WriteLine("after replace 20 to 30  a = {0}", a);
            Console.WriteLine();
        }

        static void PassByReference(ref int a)
        {
            Console.WriteLine(" a = {0}", a);
            a = 30;
            Console.WriteLine("after replace a = {0}", a);
        }
    }
}
