using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;

namespace Course.Entities
{
    class LegalPerson : Person //Pessoa Jurídica
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
    }
}
