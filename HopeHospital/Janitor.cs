using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeHospital
{
    class Janitor:EmployeeBase
    {
        //FIELDS
        private string department;
        private bool isSweeping;

        //PROPERTIES
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public bool IsSweeping
        {
            get { return this.isSweeping; }
            set { this.isSweeping = value; }
        }

        //CONSTRUCTORS
        public Janitor(int empNumber, string empName, string department, bool isSweeping)
        {
            this.empNumber = empNumber;
            this.empName = empName;
            this.department = department;
            this.isSweeping = isSweeping;

        }

        //METHODS
        public override void EmployeeInfo()
        {
            Console.Write(this.empName + "\t");
            Console.Write(this.empNumber + "\t");
            Console.Write(this.department + "\t");
            Console.Write("\t");
            Console.Write(this.isSweeping + "\n");

        }

        public override void IsEmployeeWorking()
        {
            if (this.isSweeping == true)
            {
                Console.WriteLine("Janitor {0} is sweeping now in {1}.", this.empName, this.department);
            }
            else
            {
                Console.WriteLine("Janitor {0} is not sweeping now.", this.empName);
            }
        }
    }
}
