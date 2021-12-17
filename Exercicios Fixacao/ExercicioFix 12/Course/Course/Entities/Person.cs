using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Person //Pessoa genérica
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; } //Renda Anual

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }
    }
}
