using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOnInheritance
{
    internal class Sales : Employee
    {
        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }

        public Sales(int id, string name, decimal loggedHours, decimal wage,decimal salesvolume , decimal commision)
           : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = salesvolume;
            this.Commission = commision;
        }
        private decimal CalculateBonus()
        {
            return SalesVolume  * Commission;
        }
        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nComission: ${Math.Round(Commission, 2):N0}" +
                   $"\nBonus: ${Math.Round(CalculateBonus(), 2):N0}" +
                   $"\nNet Salaty: ${Math.Round(CalculateSalary(), 2):N0}";
        }
    }
}
