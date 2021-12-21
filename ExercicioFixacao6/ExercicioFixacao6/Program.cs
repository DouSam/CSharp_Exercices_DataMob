using System;
using System.Globalization;

namespace ExercicioFixacao6
{
    class Program
    {
        static void Main(string[] args)
        {
            double cot, qtd;

            Console.Write("Qual é a cotação do dólar? ");

            cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");

            qtd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Valor a ser pago em reais = {ConversorDeMoeda.Conversor(cot,qtd).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
