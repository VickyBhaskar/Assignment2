// See https://aka.ms/new-console-template for more information
using System;
namespace Assignment2
{
    internal class Program
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Enter Employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            string employeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee Gender (M/F): ");
            char employeeGender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Salary: ");
            double employeeSalary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of Joining (DD/MM/YYYY): ");
            DateTime dateOfJoining = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            double taxRate;
            double taxAmount;

            if (employeeSalary > 90000)
            {
                 taxRate = 0.30;
            }
            else
            {
                 taxRate = 0.15;
            }
            taxAmount = employeeSalary * taxRate;

            Console.WriteLine("\nID\tEmployee Name\tEmployee Gender\tEmployee Salary\tDOJ");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"{employeeId}\t{employeeName}\t\t{employeeGender}\t\t{employeeSalary:C}\t{dateOfJoining:dd/MM/yyyy}");
            Console.WriteLine("\nYou have to pay: " + taxAmount.ToString("C"));
        }
    }
}

