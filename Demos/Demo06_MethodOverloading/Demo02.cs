using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_MethodOverloading
{
    class Demo02
    {
        
        public void DoSomething(object o)
        {
            if (o is int)               
            {
                int i = (int)o;         
                Console.WriteLine("Received integer: {0}", i);
            }
            else if (o is bool)
            {
                bool b = (bool)o;
                Console.WriteLine("Received Boolean: {0}", b);
            }

            else if(o is string)
            {
                    string s =(string)o;
                    Console.WriteLine("Received a string: {0}", s);   
            }
        }
    }
}
