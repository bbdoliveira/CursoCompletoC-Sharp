namespace Course.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate; 
        }

        public override void Witchdraw(double amount) //Método de saque diferente para SavingsAccount
        {
            base.Witchdraw(amount);
            Balance -= 2.0;
        }
    }
}
