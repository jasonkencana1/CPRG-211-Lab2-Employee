using Lab2D.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2D
{
    /// <summary>
    /// CPRG-211 Lab Inheritance
    /// </summary>
    /// <remarks>Author: Jason Kencana</remarks>
    /// <remarks>Date: January 30,2023</remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Create list that holds Employee instances
            List<Employee> employees = new List<Employee>();

            //Must be a relative path
            string path = "employees.txt";

            //Convert lines in file into an array of strings
            string[] lines = File.ReadAllLines(path);

            //Loop through each line
            foreach (string line in lines)
            {
                //Split line into parts or cells
                string[] cells = line.Split(':');

                //The first 3 cells are the ID, name, and address
                string id = cells[0];
                string name = cells[1];
                string address = cells[2];

                // TODO: Get remaining employee info from cells
                string phone = cells[3];
                string sin = cells[4];
                string birthdate = cells[5];
                string jobname = cells[6];

                //Convert SIN from string to long
                long SIN = long.Parse(cells[4]);

                //Extract the first digit of the ID
                string FirstDigit = id.Substring(0,1);

                //if (FirstDigit == "0" || FirstDigit == "1" || FirstDigit == "2" || FirstDigit == "3" || FirstDigit == "4") ;
                //Convert first digit from string to int
                int firstDigitInt = int.Parse(FirstDigit);

                //Check range of first digit
                if (firstDigitInt >= 0 && firstDigitInt <= 4)
                {
                    //Salaried 
                    string salary = cells[7];

                    //Convert salary from string to double
                    double salaryDouble = double.Parse(salary);


                    //Create Salaried instance
                    Salaried salaried = new Salaried(id, name, address, salaryDouble, phone, birthdate, jobname, SIN);

                    //Add to list of employees
                    employees.Add(salaried);
                }
                else if (firstDigitInt >= 5 && firstDigitInt <= 7)
                {
                    //Wage
                    string rate = cells[7];
                    string hours = cells[8];

                    //Convert rate and hours from string to double
                    double rateDouble = double .Parse(rate);
                    double hoursDouble = double.Parse(hours);

                    //Create Wages instance
                    Waged wages = new Waged(id, name, address, rateDouble, hoursDouble, phone, birthdate, jobname, SIN);

                    //Add to list of employees
                    employees.Add(wages);

                }
                else if (firstDigitInt >= 8 && firstDigitInt <= 9)
                {
                    //PartTime
                    string rate = cells[7];
                    string hours = cells[8];

                    // Convert rate and hours from string to double
                    double rateDouble = double.Parse(rate);
                    double hoursDouble = double.Parse(hours);

                    //Create PartTime instance
                    PartTime partTime = new PartTime(id, name, address, rateDouble, hoursDouble, phone, birthdate, jobname, SIN);

                    //Add to list of employees
                    employees.Add(partTime);
                }
            }

            /**
         * TODO:
         *  - Determine average weekly pay of all employees.
         *  - Determine highest paid waged employee.
         *  - Determine lowest paid salaried employee.
         *  - Determine percentage of employees that are salaried, waged, and part-time.
         */

            double weeklyPaySum = 0;

            // It's okay to use loop through employees multiple times.
            foreach (Employee employee in employees)
            {
                double weeklyPay = employee.CalcWeeklyPay();

                weeklyPaySum += weeklyPay;
            }

            double averageWeeklyPay = weeklyPaySum / employees.Count;

            Console.WriteLine("Average weekly pay: " + averageWeeklyPay);

            Waged highestPaidWaged = null;

            foreach (Employee employee in employees) 
            { 
                if (employee is Waged)
                {
                    Waged waged= (Waged)employee;

                    if (highestPaidWaged == null || waged.CalcWeeklyPay() > highestPaidWaged.CalcWeeklyPay() ) 
                    { 
                        //Assign current item to found
                        highestPaidWaged= waged;
                    }
                }
            }
            Console.WriteLine("Employee " + highestPaidWaged.Name + " is highest waged employee ($" + highestPaidWaged.CalcWeeklyPay() + ")");

            Salaried lowestPaidSalaried = null;

            foreach (Employee employee in employees)
            {
                if (employee is Salaried)
                {
                    Salaried salaried = (Salaried)employee;

                    if (lowestPaidSalaried == null || salaried.CalcWeeklyPay() < lowestPaidSalaried.CalcWeeklyPay())
                    {
                        //Assign current item to found
                        lowestPaidSalaried = salaried;
                    }
                }
            }
            Console.WriteLine("Employee " + lowestPaidSalaried.Name + " is lowest salaried employee ($" + lowestPaidSalaried.CalcWeeklyPay() + ")");
            /* string rate = cells[7];
             string hours = cells[8];*/

            int totalEmployees = 0;
            int salariedEmployees = 0;
            int wagesEmployees = 0;
            int partTimeEmployees = 0;

            foreach (Employee employee in employees)
            {

                totalEmployees++;

                if (employee is Salaried)
                {
                    salariedEmployees++;
                }
                else if (employee is Waged)
                {
                    wagesEmployees++;
                }
                else if (employee is PartTime)
                {
                    partTimeEmployees++;
                }
            }

            double salariedPercentage = (double)salariedEmployees/ totalEmployees * 100;
            double wagedPercentage = (double)wagesEmployees/ totalEmployees * 100;
            double partTimePercentage = (double) partTimeEmployees/ totalEmployees * 100;

            Console.WriteLine("Salaried percentage : " + salariedPercentage + "%");
            Console.WriteLine("Waged percentage : " + wagedPercentage + "%");
            Console.WriteLine("PartTime percentage : " + partTimePercentage + "%");



        }
    }
}
