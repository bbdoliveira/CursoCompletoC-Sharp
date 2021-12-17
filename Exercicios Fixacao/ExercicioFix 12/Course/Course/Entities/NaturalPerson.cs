namespace Course.Entities
{
    class NaturalPerson : Person //Pessoa física
    {
        public double HealthExpenses { get; set; }

        public NaturalPerson(string name, double annualIncome, double healthExpenses) : base(name, annualIncome)
        {
            HealthExpenses = healthExpenses;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (HealthExpenses * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenses * 0.5);
            }
        }
    }
}
