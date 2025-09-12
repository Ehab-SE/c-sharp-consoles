using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3EmployeeDatabasewithDepartment
{
    internal class Program
    {
        public enum Department { HR, IT, Sales, Finance }

        public struct Employee
        {
            public int EmployeeID;
            public string Name;
            public double Salary;
            public Department Department;
        }
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[5];
            int employeeCounter = 0;

            employees[employeeCounter].EmployeeID = 101;
            employees[employeeCounter].Name = "Hossam";
            employees[employeeCounter].Salary = 55000;
            employees[employeeCounter].Department = Department.HR;
            employeeCounter++;

            employees[employeeCounter].EmployeeID = 102;
            employees[employeeCounter].Name = "Ramy";
            employees[employeeCounter].Salary = 75000;
            employees[employeeCounter].Department = Department.IT;
            employeeCounter++;

            employees[employeeCounter].EmployeeID = 103;
            employees[employeeCounter].Name = "Habib";
            employees[employeeCounter].Salary = 48000;
            employees[employeeCounter].Department = Department.Sales;
            employeeCounter++;

            employees[employeeCounter].EmployeeID = 104;
            employees[employeeCounter].Name = "Layla";
            employees[employeeCounter].Salary = 82000;
            employees[employeeCounter].Department = Department.IT;
            employeeCounter++;

            employees[employeeCounter].EmployeeID = 105;
            employees[employeeCounter].Name = "Sameh";
            employees[employeeCounter].Salary = 60000;
            employees[employeeCounter].Department = Department.Finance;

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i].EmployeeID} \n{employees[i].Name} \n{employees[i].Salary} \n{employees[i].Department}\n\n");
            }
            Console.WriteLine();

            // Calculate and display total salaries
            double totalSalaries = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                totalSalaries += employees[i].Salary;
            }
            Console.WriteLine($"Total Salaries for all employees: ${totalSalaries}\n\n");


            double maxSalary = employees[0].Salary;
            Department highestDept = employees[0].Department;

            for (int i = 1; i < employees.Length; i++)
            {
                if (employees[i].Salary > maxSalary)
                {
                        maxSalary = employees[i].Salary;
                        highestDept = employees[i].Department;
                }
            }
            Console.WriteLine($"Department with the highest paid employee: {highestDept}");
            
        }
    }
}
