using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Department: Employee
    {

       
        public Employee[] Employees = new Employee[] {};
      
        public Department() 
        {
          
        } 

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;

            
           
        }
        public void ShowEmployeeInfo(Employee newEmployee)
        {
            

          Console.WriteLine($" Name: {newEmployee.Name}\n Surname: {newEmployee.Surname}\n Age:{newEmployee.Age}\n DepartmentName: {newEmployee.DepartmentName}\n Salary: {newEmployee.Salary}");
            
        }
        public Employee[] GetAllEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine($" Name: {Employees[i].Name}\n " +
                    $"Surname: {Employees[i].Surname}\n " +
                    $"Age: {Employees[i].Age}\n " +
                    $"DepartmentName: {Employees[i].DepartmentName}\n " +
                    $"Salary: {Employees[i].Salary}\n ");
                Console.WriteLine("-----------------------------");
            }
            return Employees ;
        }
        public Employee[] GetAllEmployeesBySalary(int minSalary,int maxSalary)
        {

            for(int i = 0;i < Employees.Length;i++) 
            {
                if (Employees[i].Salary<=maxSalary && Employees[i].Salary >= minSalary)
                {
                    Console.WriteLine($" Name: {Employees[i].Name}\n" +
                                      $"Surname:{Employees[i].Surname}\n" +
                                      $"Age:{Employees[i].Age}\n" +
                                      $"DepartmentName:{Employees[i].DepartmentName}\n" +
                                      $"Salary:{Employees[i].Salary}");
                }
            }
            return Employees ;
        }



        

    }
}
