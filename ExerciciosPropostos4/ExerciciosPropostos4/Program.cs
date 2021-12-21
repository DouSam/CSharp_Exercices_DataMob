using System;
using System.Globalization;

namespace ExerciciosPropostos4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1.Impares();
            //Ex2.Intervalo();
            //Ex3.Ponderada();
            //Ex4.Divisao();
            //Ex5.Fatorial();
            //Ex6.Divisores();
            Ex7.Potencia();
        }
    }

    public class Ex1
    {
        static public void Impares()
        {
            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    public class Ex2
    {
        static public void Intervalo()
        {
            int N = int.Parse(Console.ReadLine());
            int inside = 0;
            int outside = 0;
            int number;

            for (int i = 0; i < N; i++)
            {
                number = int.Parse(Console.ReadLine());
                if(number >= 10 && number <= 20)
                {
                    inside++;
                }
                else
                {
                    outside++;
                }
            }

            Console.WriteLine($"{inside} in\n{outside} out");
        }
    }

    public class Ex3
    {
        static public void Ponderada()
        {
            int N = int.Parse(Console.ReadLine());
            string[] entrada;
            double val1;
            double val2;
            double val3;
            double media;

            for (int i = 0; i < N; i++)
            {
                entrada = Console.ReadLine().Split(" ");

                val1 = double.Parse(entrada[0], CultureInfo.InvariantCulture);
                val2 = double.Parse(entrada[1], CultureInfo.InvariantCulture);
                val3 = double.Parse(entrada[2], CultureInfo.InvariantCulture);

                media = ((val1 * 2) + (val2 * 3) + (val3 * 5)) / (2 + 3 + 5);

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }

    public class Ex4
    {
        static public void Divisao()
        {
            int N = int.Parse(Console.ReadLine());
            string[] entrada;
            double N1;
            double N2;

            for (int i = 0; i < N; i++)
            {
                entrada = Console.ReadLine().Split(" ");

                N1 = double.Parse(entrada[0]);
                N2 = double.Parse(entrada[1]);
                if(N2 == 0)
                {
                    Console.WriteLine("Divisao impossivel");
                }
                else
                {
                    Console.WriteLine((N1/N2).ToString("F1",CultureInfo.InvariantCulture));
                }
            }
        }
    }

    public class Ex5
    {
        static public void Fatorial()
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial = (N == 0)? 1:N;

            for (N--; N > 0 ; N--)
            {
                fatorial *= N;
            }

            Console.WriteLine(fatorial);
        }
    }

    public class Ex6
    {
        static public void Divisores()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                if(N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    public class Ex7
    {
        static public void Potencia()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}
