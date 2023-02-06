using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2D.Entities
{
    /// <summary>
    /// Represents a part-time employee
    /// </summary>
    /// <remarks>Author: Jason Kencana</remarks>
    /// <remarks>Date: January 31, 2023</remarks>
    internal class PartTime : Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for part-time employee.
        private double rate;
        private double hours;

        //properties
        public double Rate { get { return rate; } }
        public double Hours { get { return hours; } }

        // This is how ID, name, and address would be set if the fields in the Employee class are private and it couldn't be modified.
        /*public PartTime(string id, string name, string address, double rate) : base(id, name, address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.rate = rate;
        }*/

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="name">Name of employee</param>
        /// <param name="address">Employee's address</param>
        /// <param name="rate">Employee's rate</param>
        /// <param name ="hours">Employees hours per week</param>
        /// <param name="phone">Employee's phone</param>
        /// <param name="birthdate">Employee's birthdate</param>
        /// <param name="jobname">Employee's jobname</param>
        /// <param name="SIN">Employee's SIN number</param>

        //constructor
        public PartTime(string id, string name, string address, double rate, double hours, string phone, string birthdate, string jobname, long SIN)
        {
            //Set in instance of inherited Employee
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.birthdate = birthdate;
            this.jobname = jobname;
            this.SIN = SIN;
            //Set in instance of this class
            this.rate = rate;
            this.hours = hours;
            
        }

        public override double CalcWeeklyPay()
        {
            double weeklyPay = 0;

            weeklyPay = this.rate * this.hours;

            return weeklyPay;
        }
    }
}
