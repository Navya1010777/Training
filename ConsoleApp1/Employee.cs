using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee

    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;

        public void GetDetails()
        {
            Console.Write("Enter Employee ID: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Department: ");
            Department = Console.ReadLine();

            Console.Write("Enter Monthly Salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Employee Details ---");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Monthly Salary: {Salary}");
        }

        public void CalculateSalaryDetails()
        {
            double annualSalary = Salary * 12;
            double bonus = Salary * 0.10; // 10% bonus

            Console.WriteLine($"\nAnnual Salary: {annualSalary}");
            Console.WriteLine($"Bonus (10% of Monthly Salary): {bonus}");
            Console.WriteLine($"Total Monthly Payout (Salary + Bonus): {(Salary + bonus)}");
        }


    }
}
