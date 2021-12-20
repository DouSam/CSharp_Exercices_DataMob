using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] entrada = Console.ReadLine().Split(" ");
            Console.WriteLine(nome);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(preco.ToString("F2"));
            Console.WriteLine($"{entrada[0]}\n{int.Parse(entrada[1])}\n{double.Parse(entrada[2], CultureInfo.InvariantCulture):F2}");
        }
    }
}
