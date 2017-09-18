using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeHospital
{
    class Nurse:EmployeeBase
    {
        //FIELDS
        private int numPatients;

        //PROPERTIES
        public int NumPatients
        {
            get { return this.numPatients; }
            set { this.numPatients = value; }
        }

        //CONSTRUCTORS
        public Nurse(int empNumber, string empName, int numPatients)
        {
            this.empNumber = empNumber;
            this.empName = empName;
            this.numPatients = numPatients;

        }

        //METHODS
        public override void EmployeeInfo()
        {
            Console.Write(this.empName + "\t");
            Console.Write(this.empNumber + "\t");
            Console.Write("\t");
            Console.Write(this.numPatients + "\n");
            
        }
    }
}
