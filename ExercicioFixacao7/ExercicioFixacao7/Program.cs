using System;
using System.Globalization;

namespace ExercicioFixacao7
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxNumero;
            string auxNome;
            double auxDeposito;
            double auxValor;
            char opcDeposito;
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            auxNumero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            auxNome = Console.ReadLine();
            Console.Write("Haverá depositvo inicial (s/n)? ");
            opcDeposito = Console.ReadLine()[0];

            if (opcDeposito == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                auxDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(auxNome,auxNumero,auxDeposito);
            }
            else
            {
                conta = new ContaBancaria(auxNome, auxNumero);
            }

            Console.WriteLine($"\n\nDados da conta:\n{conta}\n\n");

            Console.Write("Entre um valor para depósito: ");
            auxValor = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            conta.Deposito(auxValor);
            Console.WriteLine($"Dados da conta atualizados:\n{conta}\n\n");

            Console.Write("Entre um valor para saque: ");
            auxValor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(auxValor);
            Console.WriteLine($"Dados da conta atualizados:\n{conta}");
        }
    }
}
