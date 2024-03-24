using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public int Salary;

        public Employee()
        {

        }
       

        public Employee(string name)
        {
            Name = name;
        }
        public Employee(string name,string surname): this(name)
        {
            Surname = surname;
        }
        public Employee( string name, string surname, byte age): this(name, surname)
        {
            Age = age;
        }
        public Employee( string name, string surname, byte age,string departmentname):this(name, surname, age)
        {
            DepartmentName = departmentname;
        }
        public Employee(string name, string surname,byte age,string departmentname, int salary): this(name, surname, age, departmentname)
        {
            Salary = salary;
        }
        
        
            
        



    }
}
