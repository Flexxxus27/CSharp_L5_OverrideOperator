using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_L5
{
    internal class Employee
    {
        public string Name { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Responsibilities { get; set; }
        public decimal Salary { get; set; }
        public Employee(string name, DateTime dateOfBirth, string phone, string email, string position, string responsibilities, decimal salary)
        {
            this.Name = name;
            this.dateOfBirth = dateOfBirth;
            this.Phone = phone;
            this.Email = email;
            this.Position = position;
            this.Responsibilities = responsibilities;
            this.Salary = salary;
        }
        public static decimal operator +(Employee a, decimal salary)
        {
            return a.Salary + salary;
        }
        public static decimal operator -(Employee a, decimal salary)
        {
            return a.Salary + salary;
        }
        public static bool operator ==(Employee a, Employee b)
        {
            return a.Salary == b.Salary;
        }
        public static bool operator !=(Employee a, Employee b)
        {
            return a.Salary != b.Salary;
        }
        public static bool operator >(Employee a, Employee b)
        {
            return a.Salary > b.Salary;
        }
        public static bool operator <(Employee a, Employee b)
        {
            return a.Salary < b.Salary;
        }
        public override bool Equals(object? obj)
        {
            if(obj is Employee other)
            {
                return this.Salary == other.Salary;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Date: {dateOfBirth}, " +
                $"Phone: {Phone}, Email: {Email}, position:" +
                $"{Position}, responsibilites: {Responsibilities}" +
                $"Salary: {Salary}";
        }
    }
}
