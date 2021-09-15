using System;
using System.Globalization;

namespace ExercicioFix_Conta_Bancaria
{
    class ContaBancaria
    {
        private char _deposito;
        private double _saldo;
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo
        {
            get { return _saldo; }
        }

        public ContaBancaria(int numero, string nome, char deposito, double quantia)
        {
            Numero = numero;
            Titular = nome;
            _deposito = deposito;
            _saldo = quantia;
        }

        public ContaBancaria(int numero, string nome, char deposito)
        {
            Numero = numero;
            Titular = nome;
            _deposito = deposito;
        }

  
        public double Deposito(double quantia)
        {
            return _saldo += quantia;
        }
        public void Saque (double quantia)
        {
            _saldo -= quantia + 5;
        }
    }
}
