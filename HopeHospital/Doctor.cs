using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeHospital
{
    class Doctor:EmployeeBase
    {
        //FIELDS
        private string specialtyArea;

        //PROPERTIES
        public string SpecialtyArea
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }

        //CONSTRUCTORS
        public Doctor(int empNumber, string empName, string specialtyArea)
        {
            this.empNumber = empNumber;
            this.empName = empName;
            this.specialtyArea = specialtyArea;
        }

        //METHODS
        public override void EmployeeInfo()
        {            
            Console.Write(this.empName+"\t");
            Console.Write(this.empNumber + "\t");
            Console.Write(this.specialtyArea + "\n");
        }

    }
}
