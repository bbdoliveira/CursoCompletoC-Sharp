using System.Globalization;

namespace Course
{
    class ContaBancaria
    {
        public int Numero { get; private set; } //Não poderá ser mudado por "fora".
        public string Titular { get; set; } //Pode haver mudaçãs externas.
        public double Saldo { get; private set; } //Só vai poder ser mudada por dentro da classe.

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        //Usando a palavra this eu aproveito os argumentos do construtor anterior
        //para isso eu preciso passar como argumento do construtor anterior
        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString() //Sobrescreve o metodo ToString().
        {
            return "Conta " + Numero + ", Titular: " + Titular + ", Saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
