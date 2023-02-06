using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2D.Entities
{
    /// <summary>
    /// Represents an Employee
    /// </summary>
    /// <remarks>Author : Jason Kencana</remarks>
    /// <remarks>Date: January 31, 2023</remarks>
    internal class Employee
    {
        // TODO: Add remaining fields, properties, and constructor parameters for general employee.
        protected string id;
        protected string name;
        protected string address;
        protected string phone;
        protected string birthdate;
        protected string jobname;
        protected long SIN;

        //properties
        public string ID { get { return id; } }
        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public string Phone { get { return phone; } }
        public string Birthdate { get { return birthdate; } }
        public string Jobname { get { return jobname; } }
        public long Sin { get { return SIN; } }

        //no arg constructor
        public Employee() { }

        /// <summary>
        /// User-defined constructor
        /// </summary>
        /// <param name="id">Employee ID</param>
        /// <param name="name">Name of employee</param>
        /// <param name="address">Employee's address</param>
        /// <param name="phone">Employee's phone</param>
        /// <param name="birthdate">Employee's birthdate</param>
        /// <param name="jobname">Employee's jobname</param>
        /// <param name="SIN">Employee's SIN number</param>
        public Employee(string id, string name, string address, string phone, string birthdate, string jobname, long SIN)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.birthdate = birthdate;
            this.jobname = jobname;
            this.SIN = SIN;
        }

        public virtual double CalcWeeklyPay() 
        {
            return 0; 
        }
    }
}
