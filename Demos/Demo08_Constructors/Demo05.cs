using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Constructors.Demo05
{
    class Demo
    {
        public static void Run()
        {
            

            A objA = new B();
           
        }
    }

    class A
    {
        public A()
        {
            Console.WriteLine("Instance constructor of A() called");
        }

        static A()
        {
            Console.WriteLine("Type constructor of A() called");
        }
    }


    class B : A
    {
        public B()
        {
            Console.WriteLine("Instance constructor of B() called");
        }

        static B()
        {
            Console.WriteLine("Type constructor of B() called");
        }
    }
}
