using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2D.Entities
{
    /// <summary>
    /// Represents a Salaried employee
    /// </summary>
    /// <remarks>Author: Jason Kencana</remarks>
    /// <remarks>Date: January 30,2023</remarks>
    internal class Salaried : Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for salaried employee.

        private double salary;

        //properties
        public double Salary { get { return salary; } }



        // This is how ID, name, and address would be set if the fields in the Employee class are private and it couldn't be modified.
        /*public Salaried(string id, string name, string address, double salary) : base(id, name, address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.salary = salary;
        }*/

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="name">Name of employee</param>
        /// <param name="address">Employee's address</param>
        /// <param name="salary">Employee's salary</param>
        /// <param name="phone">Employee's phone</param>
        /// <param name="birthdate">Employee's birthdate</param>
        /// <param name="jobname">Employee's jobname</param>
        /// <param name="SIN">Employee's SIN number</param>

        public Salaried(string id, string name, string address, double salary, string phone, string birthdate, string jobname, long SIN)
        {
            //Set an instance of inherited Employee
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.birthdate = birthdate;
            this.jobname = jobname;  
            this.SIN = SIN; 
            //Set an instance of this class
            this.salary = salary;
        }

        public override double CalcWeeklyPay()
        {
            return this.salary;
        }
    }
}
