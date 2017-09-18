using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopeHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating lists for each class
            //List<int> employees = new List<int>();//if don't know elements, use .Add
            List<int> employees = new List<int>();
            List<string> doctors = new List<string>();
            List<string> surgeons = new List<string>();
            List<string> nurses = new List<string>();
            List<string> admins = new List<string>();
            List<string> receptions = new List<string>();
            List<string> janitors = new List<string>();
           
           

            //Task # 1 - Entering Employee data - can either have an initial group and ability to add to it

            Doctor doctor1 = new Doctor(101, "David", "pediatrics");
            Doctor doctor2 = new Doctor(102, "Rani", "neurology");
            Surgeon surgeon1 = new Surgeon(201, "Rex", "oncology", false);
            Surgeon surgeon2 = new Surgeon(202, "Sally", "neurology", true);
            Nurse nurse1 = new Nurse(301, "Bob", 12);
            Nurse nurse2 = new Nurse(302, "Sue", 18);
            Administrator admin1 = new Administrator(401, "Pat", "pediatrics");
            Administrator admin2 = new Administrator(402, "Bobby", "oncology");
            Receptionist reception1 = new Receptionist(501, "Yanni", "neurology", true);
            Receptionist reception2 = new Receptionist(502, "Fred", "pediatrics", false);
            Janitor janitor1 = new Janitor(601, "Susan", "pediatrics", true);
            Janitor janitor2 = new Janitor(602, "Felix", "oncology", true);


            //Task # 2 - Printing out the Employees

            Console.WriteLine("Name\t Number\t Department\t #patients\t isWorking?");
            doctor1.EmployeeInfo();
            doctor2.EmployeeInfo();
            surgeon1.EmployeeInfo();
            surgeon2.EmployeeInfo();
            nurse1.EmployeeInfo();
            nurse2.EmployeeInfo();
            admin1.EmployeeInfo();
            admin2.EmployeeInfo();
            reception1.EmployeeInfo();
            reception2.EmployeeInfo();
            janitor1.EmployeeInfo();
            janitor2.EmployeeInfo();
            Console.WriteLine();

            //Print out who is working
            Console.WriteLine("Who is working right now?");
            surgeon1.IsEmployeeWorking();
            surgeon2.IsEmployeeWorking();
            reception1.IsEmployeeWorking();
            reception2.IsEmployeeWorking();
            janitor1.IsEmployeeWorking();
            janitor2.IsEmployeeWorking();
            Console.WriteLine();

        }
    }
}
