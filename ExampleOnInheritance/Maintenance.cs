using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOnInheritance
{
    internal class Maintenance : Employee
    {
        private const decimal HardShip = 100m;
        public Maintenance(int id, string name, decimal loggedHours, decimal wage)
            :base(id, name, loggedHours, wage)
        {

        }

        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + HardShip;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nHardship: ${Math.Round(HardShip, 2):N0}" +
                   $"\nNet Salaty: ${Math.Round(CalculateSalary(), 2):N0}";
        }
    }
}
