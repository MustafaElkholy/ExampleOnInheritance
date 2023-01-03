using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleOnInheritance
{
    internal class Developer :Employee
    {
        protected bool TaskCompleted { get; set; }
        private const decimal Commission = .03m;

        public Developer(int id, string name, decimal loggedHours, decimal wage, bool taskcompleted)
          : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = taskcompleted;
        }
        private decimal CalculateBonus()
        {
           if(TaskCompleted)
            {
                return Commission * base.CalculateSalary();
            }
           return 0; // don't calculate Bonus
        }
        protected override decimal CalculateSalary()
        {
            return base.CalculateSalary() + CalculateBonus();
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nTask Completed?: {(TaskCompleted ? "Yes" : "No")}" +
                   $"\nBonus: ${Math.Round(CalculateBonus(), 2):N0}" +
                   $"\nNet Salaty: ${Math.Round(CalculateSalary(), 2):N0}";
        }
    }
}
