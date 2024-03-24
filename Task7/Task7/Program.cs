using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Ali";
            employee1.Surname = "Memmedov";
            employee1.Age = 19;
            employee1.DepartmentName = "Pasa Bank";
            employee1.Salary = 2500;

            Employee employee2 = new Employee();
            employee2.Name = "Qosqar";
            employee2.Surname = "Dasdiyev";
            employee2.Age = 26;
            employee2.DepartmentName = "Kapital Bank";
            employee2.Salary = 3500;

            Employee employee3 = new Employee();
            employee3.Name = "Esref";
            employee3.Surname = "Esrefov";
            employee3.Age = 18;
            employee3.DepartmentName = "Kapital Bank";
            employee3.Salary = 1800;


            Department department = new Department();
            Employee newEmployee = new Employee();
            
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
           

            int choice;

            do
            {

                Console.WriteLine("Menu:\n1. Employee elave et\n2. Bütün iscilere bax\n3. Maaş aralığına göre işçileri axtarış et\n0. Proqramı bitir");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Adi daxil edin");
                    string name = Console.ReadLine();

                    Console.WriteLine(" ");
                    Console.WriteLine("Soyadi daxil edin");
                    string surname = Console.ReadLine();

                    Console.WriteLine(" ");
                    string ageStr = " ";
                    byte age;

                    do
                    {
                        Console.WriteLine("Yasi daxil edin");
                        ageStr = Console.ReadLine();
                    }
                    while (!byte.TryParse(ageStr, out age));

                    Console.WriteLine(" ");
                    Console.WriteLine("Department adini daxil edin");
                    string departmentname = Console.ReadLine();

                    Console.WriteLine(" ");
                    string salaryStr = " ";
                    int salary;

                    do
                    {
                        Console.WriteLine("Maasi daxil edin");
                        salaryStr = Console.ReadLine();
                    }
                    while (!int.TryParse(salaryStr, out salary));

                    newEmployee = new Employee(name, surname, age, departmentname, salary);
                    Console.WriteLine("Isci elave edildi!");

                    department.AddEmployee(newEmployee);
                    department.ShowEmployeeInfo(newEmployee);



                }

                else if (choice == 2)
                {
                    department.GetAllEmployees();
                   

                }
                else if (choice == 3)
                {
                    Console.WriteLine(" ");
                    string minSalaryStr = " ";
                    int minSalary;
                    do
                    {
                        Console.WriteLine("minsalary deyerini daxil edin");
                        minSalaryStr = Console.ReadLine();

                    }
                    while (!int.TryParse(minSalaryStr, out minSalary));
                  
                    Console.WriteLine(" ");
                    string maxSalaryStr = " ";
                    int maxSalary;
                    do
                    {
                        Console.WriteLine("maxsalary deyerini daxil edin");
                        maxSalaryStr = Console.ReadLine();

                    }
                    while (!int.TryParse(maxSalaryStr, out maxSalary));

                    department.GetAllEmployeesBySalary(minSalary, maxSalary);
                    
                }
            }
            while (choice!=0);
            Console.WriteLine("Proqram bitdi!");

        }
       

    }
}
