using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeHospital
{
    class Receptionist:EmployeeBase
    {
        //FIELDS
        private string department;
        private bool isOnPhone;

        //PROPERTIES
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public bool IsOnPhone
        {
            get { return this.isOnPhone; }
            set { this.isOnPhone = value; }
        }

        //CONSTRUCTORS
        public Receptionist(int empNumber, string empName, string department, bool isOnPhone)
        {
            this.empNumber = empNumber;
            this.empName = empName;
            this.department = department;
            this.isOnPhone = isOnPhone;
        }

        //METHODS
        public override void EmployeeInfo()
        {
            Console.Write(this.empName + "\t");
            Console.Write(this.empNumber + "\t");
            Console.Write(this.department + "\t");
            Console.Write("\t");
            Console.Write(this.isOnPhone +"\n");

        }
        public override void IsEmployeeWorking()
        {
            if (this.isOnPhone == true)
            {
                Console.WriteLine("Receptionist {0} is on the phone now in {1}.", this.empName, this.department);
            }
            else
            {
                Console.WriteLine("Receptionist {0} is not on the phone.", this.empName);
            }
        }
    }
}
