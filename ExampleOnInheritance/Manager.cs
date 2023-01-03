using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOnInheritance
{
    internal class Manager : Employee
    {
        private const decimal AllowanceRate = 0.05m;
        public Manager(int id, string name, decimal loggedHours, decimal wage)
           : base(id, name, loggedHours, wage)
        {

        }
        private decimal CalculateAllowance()
        {
            return AllowanceRate * base.CalculateSalary();
        }
        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateAllowance();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nAllowance: ${Math.Round(CalculateAllowance(),2):N0}" +
                   $"\nNet Salaty: ${Math.Round(CalculateSalary(),2):N0}";
        }

    }
}
