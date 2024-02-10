using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroBancario
{
    // CLASSE:

    internal class ContaBancaria
    {

        // PROPRIEDADES:

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // CONSTRUTORES:

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
            Saldo = 0;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        // MÉTODOS:

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + Titular + "," + " Saldo: $" + Saldo.ToString("F2");
        }

    }
}