using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class NaturalPerson : Person //Pessoa física
    {
        public double HealthExpenses { get; set; }

        public NaturalPerson(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }
    }
}
