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
            //Console.WriteLine("Exercicio 5");
            //Ex5.Valor();
            Console.WriteLine("Exercicio 6");
            Ex6.Areas();
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
            double pi   = 3.14159;
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

    public class Ex5
    {
        public static void Valor()
        {
            string[] peca1 = Console.ReadLine().Split(" ");
            string[] peca2 = Console.ReadLine().Split(" ");

            double qtdPeca1 = double.Parse(peca1[1], CultureInfo.InvariantCulture);
            double valPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            double qtdPeca2 = double.Parse(peca2[1], CultureInfo.InvariantCulture);
            double valPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double valorTotal = (qtdPeca1 * valPeca1) + (qtdPeca2 * valPeca2);

            Console.WriteLine($"VALOR A PAGAR: R${valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }

    public class Ex6
    {
        public static void Areas()
        {
            string[] entrada = Console.ReadLine().Split(" ");

            double a = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double b = double.Parse(entrada[1], CultureInfo.InvariantCulture);
            double c = double.Parse(entrada[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2;
            double circulo   = Math.PI * Math.Pow(c, 2);
            double trapezio  = ((a + b) * c) / 2;
            double quadrado  = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO  : {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO : {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO : {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
