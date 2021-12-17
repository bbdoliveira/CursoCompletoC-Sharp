namespace Course.Entities
{
    abstract class Person //Pessoa genérica
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; } //Renda Anual

        public Person(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
    }
}
