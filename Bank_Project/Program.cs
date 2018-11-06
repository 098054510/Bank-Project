using System;
using System.Globalization;

namespace Bank_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P;
            string resp, resp3, resp4;

            Console.WriteLine("Digite o nome do associado.");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe o número da conta.");
            Console.Write("Conta :");
            int NumeroDeConta = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Fazer Deposito inicial? [S/N]");
            resp = Console.ReadLine();

            P = new Pessoa(nome);
            if (resp == "s")
            {
                Console.WriteLine("insira o valor a ser depositado.");
                Console.Write("Deposito: R$");
                double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                P.Depositar(quantia);
                Console.WriteLine("Conta Criada! Associado: " + P.nome);
                Console.WriteLine("Conta: " + NumeroDeConta);
                Console.WriteLine("Total em Conta: R$" + P.Saldo);
            }
            else if (resp == "n")
            {
                Console.WriteLine("Informações de Conta: " + P.nome + ", Conta N° " + NumeroDeConta);
                Console.WriteLine("Saldo Atual: R$" + P.Saldo);
            }

            Console.WriteLine("Deseja fazer/repetir alguma operação? [S/N]");
            resp3 = Console.ReadLine();
            if (resp3 == "s")
            {
                Console.WriteLine("Qual operação deseja fazer? ");
                Console.WriteLine("Deposito [1]");
                Console.WriteLine("Saque [2]");
                Console.WriteLine("Saldo [3]");
                resp4 = Console.ReadLine();

                if (resp4 == "1")
                {
                    Console.WriteLine("Digite o valor do deposito.");
                    Console.Write("Deposito: R$");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    P.Depositar(quantia);
                    Console.WriteLine("Deposito realizado! Total em Conta: R$" + P.Saldo);
                    Console.WriteLine("Deseja fazer/repetir alguma operação? [S/N]");
                    resp3 = Console.ReadLine();
                }
                else if (resp4 == "2")
                {
                    Console.WriteLine("Digite o valor do saque.");
                    Console.Write("Saque: R$");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    P.Sacar(quantia);
                    Console.WriteLine("Saque realizado com sucesso! Total em Conta: R$" + P.Saldo);
                    Console.WriteLine("Deseja fazer/repetir alguma operação? [S/N]");
                    resp3 = Console.ReadLine();
                }
                else if (resp4 == "3")
                {
                    Console.WriteLine("Informações de Conta: " + P.nome + ", Conta N° " + NumeroDeConta);
                    Console.WriteLine("Saldo Atual: R$" + P.Saldo);
                    Console.WriteLine("Deseja fazer/repetir alguma operação? [S/N]");
                    resp3 = Console.ReadLine();
                }
            }
            else if (resp3 == "n")
            {
                Console.WriteLine("Obrigado. Tenha um bom dia " + P.nome + " :D");
            }
            
            while (resp3 == "s")
            {
                Console.WriteLine("Qual operação deseja fazer? ");
                Console.WriteLine("Deposito [1]");
                Console.WriteLine("Saque [2]");
                Console.WriteLine("Saldo [3]");
                resp4 = Console.ReadLine();

                if (resp4 == "1")
                {
                    Console.WriteLine("Digite o valor do deposito.");
                    Console.Write("Deposito: R$");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    P.Depositar(quantia);
                    Console.WriteLine("Deposito realizado! Total em Conta: R$" + P.Saldo);
                    Console.WriteLine("Deseja fazer/repetir alguma operação? [S/N]");
                    resp3 = Console.ReadLine();
                }
                else if (resp4 == "2")
                {
                    Console.WriteLine("Digite o valor do saque.");
                    Console.Write("Saque: R$");
                    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    P.Sacar(quantia);
                    Console.WriteLine("Saque realizado com sucesso! Total em Conta: R$" + P.Saldo);
                    Console.WriteLine("Deseja fazer/repetir alguma operação? [S/N]");
                    resp3 = Console.ReadLine();
                }
                else if (resp4 == "3")
                {
                    Console.WriteLine("Informações de Conta: " + P.nome + ", Conta N° " + NumeroDeConta);
                    Console.WriteLine("Saldo Atual: R$" + P.Saldo);
                    Console.WriteLine("Deseja fazer/repetir alguma operação? [S/N]");
                    resp3 = Console.ReadLine();
                }
            }
            Console.WriteLine("Obrigado. Tenha um bom dia " + P.nome + " :D");
            Console.ReadLine();
        }
    }
}
