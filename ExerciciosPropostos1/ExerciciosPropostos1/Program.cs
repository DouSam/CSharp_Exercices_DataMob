using System;
using System.Globalization;

namespace ExerciciosPropostos1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Exercicio 1");
            //Ex1.Soma();
            //Console.WriteLine("Exercicio 2");
            //Ex2.Raio();
            //Console.WriteLine("Exercicio 3");
            //Ex3.Diferenca();
            //Console.WriteLine("Exercicio 4");
            //Ex4.Salario();
        }
    }

    public class Ex1
    {
        public static void Soma()
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"SOMA: {soma}");
        }
    }

    public class Ex2
    {
        public static void Raio()
        {
            double pi    = 3.14159;
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio,2);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }

    public class Ex3
    {
        public static void Diferenca()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = a * b - c * d;

            Console.WriteLine($"DIFERENCA = {diferenca}");
        }
    }

    public class Ex4
    {
        public static void Salario()
        {
            int number = int.Parse(Console.ReadLine());
            double horasTrab = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horasTrab * valorHora;

            Console.WriteLine($"NUMBER = {number}\nSALARY = U$ {salario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
