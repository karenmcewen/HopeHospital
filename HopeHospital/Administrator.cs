using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeHospital
{
    class Administrator:EmployeeBase
    {
        //FIELDS
        private string department;

        //PROPERTIES
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        //CONSTRUCTORS
        public Administrator(int empNumber, string empName, string department)
        {
            this.empNumber = empNumber;
            this.empName = empName;
            this.department = department;

        }

        //METHODS
    }
}
