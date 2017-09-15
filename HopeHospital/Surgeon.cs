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
    }
}
