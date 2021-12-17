namespace Course.Entities
{
    class LegalPerson : Person //Pessoa Jurídica
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            if (NumberOfEmployees > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
