using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class MyClass
    {
        private int _id;
        public int ID
        {
            get { return _id; }

            set
            {
                if (value <= 18 || value >= 65)
                { 
                    Console.WriteLine("Age Should be between 18 to 65");
                }
                else 
                {
                    _id = value;
                }
            }
        }
        
        


       
    }
}
