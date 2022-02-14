using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10_Indexer
{
   

    class Company
    {
        
         
        public string CompanyName { get; private set; }

        // Aggregated Collection.
        private System.Collections.ArrayList theEmployees { get; set; }
        private int counter;



        public Employee this[int id]
        {
            get
            {
                Employee empRetVal = null;

                foreach(Employee emp in this.theEmployees)
                {
                    if( emp.EmployeeID == id)
                    {
                        empRetVal = emp;
                        break;
                    }
                }

                return empRetVal;
            }
        }

        public Employee this[string name]
        {
            get
            {
                Employee empRetVal = null;

                foreach (Employee emp in this.theEmployees)
                {
                    if (emp.EmployeeName == name)
                    {
                        empRetVal = emp;
                        break;
                    }
                }

                return empRetVal;
            }
        }

        public Company(string name)
        {
            this.CompanyName = name;

            this.theEmployees = null;                   // Late-Instantiation Pattern
            this.counter = 0;
        }

        public void AddEmployee(string name)
        {
            Employee empNew = new Employee();
            empNew.EmployeeID = ++this.counter; 
            empNew.EmployeeName = name;

            if(this.theEmployees == null)               // check if the Late-Instantiation Collection is NULL
            {
                this.theEmployees = new System.Collections.ArrayList();     // Instantiation
            }

            // add the newly created employee object to the collection.
            this.theEmployees.Add(empNew);
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("--- List of employees of {0}", this.CompanyName);
            foreach(Employee emp in this.theEmployees)
            {
                Console.WriteLine("{0} {1}", emp.EmployeeID, emp.EmployeeName);
            }
        }
    }
}