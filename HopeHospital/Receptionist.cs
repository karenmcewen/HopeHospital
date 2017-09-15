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
    }
}
