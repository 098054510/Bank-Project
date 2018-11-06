using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Bank_Project
{
    class Pessoa
    {
        public string nome { get; set; }
        public int NumeroDeConta { get; private set; }
        public double Saldo { get; set; }
        public double Saque { get; private set; }
        public double Deposito { get; set; }

        public Pessoa(string nome, double Saldo)
        {
            this.nome = nome;
            Saldo = Saldo;
        }
        public Pessoa(string nome)
        {
            this.nome = nome;
            Saldo = 0.0;
        }
        public void Sacar(double quantia)
        {
            Saldo = Saldo - quantia - 5.00;
        }

        public void Depositar(double quantia)
        {
            Saldo = Saldo + quantia;
        }

        public override string ToString()
        {
            return "Conta: " +
                NumeroDeConta +
                "Associado: " +
                nome +
                "Saldo: " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
