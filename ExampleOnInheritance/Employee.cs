using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOnInheritance
{
    internal class Employee
    {
        public const int MinimumLoggedHours = 176;
        public const decimal overTimeRate = 1.25m;

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }

        public Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

     
        private decimal CalculateBaseSalary()
        {
            return Wage * LoggedHours;
        }

        private decimal CalculateOverTime()
        {
            var aditionalHours = ((LoggedHours - MinimumLoggedHours) > 0 ? LoggedHours - MinimumLoggedHours : 0);
            return aditionalHours * Wage * overTimeRate;

        }
        protected virtual decimal CalculateSalary()
        {
            return CalculateBaseSalary() + CalculateOverTime();
        }

        public override string ToString() 
        {
            var employeeType = GetType().ToString().Replace("ExampleOnInheritance.", ""); // replace namespace. by empty string 
            return $"{employeeType}" +
                   $"\nId: {Id}" +
                   $"\nName: {Name}" +
                   $"\nLogged Hours: {LoggedHours} hrs" +
                   $"\nWage: {Wage} $/hrs" +
                   $"\nBase Salary: ${Math.Round(CalculateBaseSalary(),2)}" +
                   $"\nOver Time Salary: ${Math.Round(CalculateOverTime(),2)}";
        }
    }
}
