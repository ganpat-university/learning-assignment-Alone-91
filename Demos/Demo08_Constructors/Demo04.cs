using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Constructors.Demo04
{
    class Person
    {
        
        public readonly int ID;
        public readonly string Name;

        
        static private int counter;

        
        static Person()
        {
            Person.counter = 0;
        }

       
        public Person(string name)
        {
            this.ID = ++Person.counter;
            this.Name = name;
        }
    }
}
