using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2D.Entities
{
    /// <summary>
    /// Represents a waged employee
    /// </summary>
    /// <remarks>Author: Jason Kencana</remarks>
    /// <remarks>Date: January 31, 2023</remarks>
    internal class Waged : Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for waged employee.
        private double rate;
        private double hours;

        //properties
        public double Rate { get { return rate; } }
        public double Hours { get { return hours; } }

        // This is how ID, name, and address would be set if the fields in the Employee class are private and it couldn't be modified.
        /*public Waged(string id, string name, string address, double rate) : base(id, name, address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.rate = rate;
        }*/

        /// <summary>
        /// User-defined consturctor
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="name">Name of employee</param>
        /// <param name="address">Employee's address</param>
        /// <param name="rate">Employee's rate</param>
        /// <param name="hours">Employees hours per week</param>
        /// <param name="phone">Employee's phone</param>
        /// <param name="birthdate">Employee's birthdate</param>
        /// <param name="jobname">Employee's jobname</param>
        /// <param name="SIN">Employees' SIN number</param>
        public Waged(string id, string name, string address, double rate,double hours, string phone, string birthdate, string jobname, long SIN)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.rate = rate;
            this.hours = hours;
            this.phone = phone;
            this.birthdate = birthdate;
            this.jobname = jobname;
            this.SIN = SIN;
        }

        public override double CalcWeeklyPay()
        {
            double weeklyPay = 0;

            if(this.hours < 40) 
            {
                weeklyPay = this.hours * this.rate;
            }
            else
            {
                double overtimeHours = this.hours - 40;

                weeklyPay = 40 * this.rate;

                double overtimePay = overtimeHours * (this.rate * 1.5);

                weeklyPay += overtimePay;
            }

            return weeklyPay;
        }
    }
}
