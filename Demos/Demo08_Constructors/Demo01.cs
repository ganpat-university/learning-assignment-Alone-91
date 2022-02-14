using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo08_Constructors.Demo01
{
    public class Demo
    {
        static public void Run()
        {
            Employee emp = new Employee("First Employee");
            Console.WriteLine("{0}", emp.Name);
        }
    }

    class Employee
    {
        public Employee(string name)
        {
            _name = name;
        }


        
        private string _name;

       
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
