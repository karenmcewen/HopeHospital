using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeHospital
{
    class Surgeon:EmployeeBase
    {
        //FIELDS
        private string specialtyArea;
        private bool isOperating;

        //PROPERTIES
        public string SpecialtyArea //using the same name as the Doctor class - will this be a problem?
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }

        public bool IsOperating
        {
            get { return this.isOperating; }
            set { this.isOperating = value; }
        }

        //CONSTRUCTORS
        public Surgeon(int empNumber, string empName, string specialtyArea, bool isOperating)
        {
            this.empNumber = empNumber;
            this.empName = empName;
            this.specialtyArea = specialtyArea;
            this.isOperating = isOperating;            
        }

        //METHODS
        public override void EmployeeInfo()
        {
            Console.Write(this.empName + "\t");
            Console.Write(this.empNumber + "\t");
            Console.Write(this.specialtyArea + "\t");
            Console.Write("\t");
            Console.Write(this.isOperating + "\n");

            //string employeeList = ($"{empName}\t\t{empNumber}\t\t{specialtyArea}\t\t{isOperating})
        }

        public override void IsEmployeeWorking()
        {
            if(this.isOperating == true)
            {
                Console.WriteLine("Surgeon {0} is operating now in the {1} OR.", this.empName, this.specialtyArea);
            }
            else
            {
                Console.WriteLine("Surgeon {0} is not operating now.", this.empName);
            }
        }
    }
}
