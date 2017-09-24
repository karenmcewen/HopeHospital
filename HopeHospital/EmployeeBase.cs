using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeHospital
{
    class EmployeeBase
    {
        //FIELDS
        //protected fields - can be accessed by parent and derived classes
        protected int empNumber;
        protected string empName;
        

        //PROPERTIES
        public int EmpNumber
        {
            get { return this.empNumber; }
            set { this.empNumber = value; }
        }

        public string EmpName
        {
            get { return this.empName; }
            set { this.empName = value; }
        }
       
        //CONSTRUCTORS

        public EmployeeBase() //must have a null constructor for the base class
        {
        }

        public EmployeeBase(int empNumber, string empName)
        {
            this.empNumber = empNumber;
            this.empName = empName;           
        }

        //METHODS -derived classes can override methods from the parent class using "virtual" keyword
        //we could use the "ABSTRACT" keyword if we want to ensure that the child classes MUST override
        public virtual void EmployeeInfo()
        {                        
        }
        public virtual void IsEmployeeWorking()
        {
        }

       public virtual void PayEmployee()
        {
        }
    }
}
