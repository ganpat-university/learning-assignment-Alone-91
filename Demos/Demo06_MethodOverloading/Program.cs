using System;

namespace Demo06_MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Demo01 obj = new Demo01();
            obj.DoSomething(10);
            obj.DoSomething("hello world");
            obj.DoSomething(true);



            int i = 10;
            bool b = false;

            object o = i;           
            int j = (int)o;         


            Demo02 obj2 = new Demo02();
            obj2.DoSomething(10);
            obj.DoSomething("hello world");
            obj2.DoSomething(false);
        }
    }
}
