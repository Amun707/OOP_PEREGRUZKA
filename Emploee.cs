using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PEREGRUZKA
{
    internal class Employee
    {
        public string Name { get; set; }
        public DateTime dateOfBorn { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Responsibility { get; set; }
        public decimal Salare { get; set; }
        public Employee(string fullName, DateTime dateOfBorn, string phoneNumber, string email, string position, string responsibilities, decimal salary)
        {
            this.Name = fullName;
            this.dateOfBorn = dateOfBorn;
            this.Phone = phoneNumber;
            this.Email = email;
            this.Position = position;
            this.Responsibility = responsibilities;
            this.Salare = salary;
        }
        public static decimal operator +(Employee a, decimal salary)
            {
            return a.Salare + salary;
            }
        public static decimal operator -(Employee a, decimal salary)
        {
            return a.Salare - salary;
        }
        public static bool operator ==(Employee a, Employee b)
        {
            return a.Salare == b.Salare;
        }
        public static bool operator !=(Employee a, Employee b)
        {
            return a.Salare != b.Salare;
        }
        public static bool operator >(Employee a, Employee b)
        {
            return a.Salare > b.Salare;
        }
        public static bool operator <(Employee a, Employee b)
        {
            return a.Salare < b.Salare;
        }
        public override bool Equals(object? obj)
        {
            if(obj is Employee other) {
                return this.Salare == other.Salare;
            }
            return false;
        }
        public override string ToString()
        {
            return $"Name:{Name},Date:{dateOfBorn}, Phone:{Phone}, Email:{Email}, Position:{Position}, "+
                $"Responsibilities:{Responsibility}, Salare:{Salare}";
        }
    }
    
}
