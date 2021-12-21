using System;
using System.Globalization;

namespace ExerciciosPropostos2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1.Sinal();
            //Ex2.Paridade();
            //Ex3.Mutiplo();
            //Ex4.Duracao();
            //Ex5.Valor();
            //Ex6.Intervalo();
            //Ex7.Quadrante();
            //Ex8.Imposto();
        }
    }

    public class Ex1
    {
        static public void Sinal()
        {
            int numero = int.Parse(Console.ReadLine());

            string signal;

            if (numero < 0)
            {
                signal = "NEGATIVO";
            }
            else
            {
                signal = "POSITIVO";
            }

            Console.WriteLine(signal);
        }
    }

    public class Ex2
    {
        static public void Paridade()
        {
            int numero = int.Parse(Console.ReadLine());

            string saida;

            if (numero % 2 == 0)
            {
                saida = "PAR";
            }
            else
            {
                saida = "IMPAR";
            }

            Console.WriteLine(saida);
        }
    }

    public class Ex3
    {
        static public void Mutiplo()
        {
            string[] entrada = Console.ReadLine().Split(" ");
            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            string saida;

            if (a % b == 0 || b % a == 0)
            {
                saida = "Sao multiplos";
            }
            else
            {
                saida = "Nao sao multiplos";
            }

            Console.WriteLine(saida);
        }
    }

    public class Ex4
    {
        static public void Duracao()
        {
            string[] entrada = Console.ReadLine().Split(" ");

            int inicio = int.Parse(entrada[0]);
            int final = int.Parse(entrada[1]);

            string saida;

            if (inicio == final)
            {
                saida = "24";
            }
            else if (inicio < final)
            {
                saida = (final - inicio).ToString();
            }
            else
            {
                saida = (24 - (inicio - final)).ToString();
            }

            saida = $"O JOGO DUROU {saida} HORA(S)";

            Console.WriteLine(saida);
        }
    }

    public class Ex5
    {
        static public void Valor()
        {
            string[] entrada = Console.ReadLine().Split(" ");
            string saida;

            double codigo = int.Parse(entrada[0]);
            double qtd = int.Parse(entrada[1]);

            if (codigo == 1)
            {
                saida = (qtd * 4).ToString("F2", CultureInfo.InvariantCulture);
            }
            else if (codigo == 2)
            {
                saida = (qtd * 4.5).ToString("F2", CultureInfo.InvariantCulture);
            }
            else if (codigo == 3)
            {
                saida = (qtd * 5).ToString("F2", CultureInfo.InvariantCulture);
            }
            else if (codigo == 4)
            {
                saida = (qtd * 2).ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                saida = (qtd * 1.5).ToString("F2", CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"Total: R$ {saida}");
        }
    }

    public class Ex6
    {
        static public void Intervalo()
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string saida;

            if (valor >= 0 && valor <= 25)
            {
                saida = "Intervalo [0,25]";
            } 
            else if (valor > 0 && valor <= 50)
            {
                saida = "Intervalo (25,50]";
            }
            else if(valor > 0 && valor <= 75)
            {
                saida = "Intervalo (50,75]";
            }
            else if(valor > 0 && valor <= 100)
            {
                saida = "Intervalo (75,100]";
            }
            else
            {
                saida = "Fora de intervalo";
            }

            Console.WriteLine(saida);
        }
    }

    public class Ex7
    {
        static public void Quadrante()
        {
            string[] entrada = Console.ReadLine().Split(" ");

            double x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
            double y = double.Parse(entrada[1], CultureInfo.InvariantCulture);

            string quadrante;

            if (x > 0 && y > 0)
            {
                quadrante = "Q1";
            }
            else if (x < 0 && y > 0)
            {
                quadrante = "Q2";
            }
            else if (x < 0 && y <0)
            {
                quadrante = "Q3";
            }
            else if (x > 0 && y < 0)
            {
                quadrante = "Q4";
            }
            else if (x == 0 && y == 0)
            {
                quadrante = "Origem";
            }
            else
            {
                if (x == 0)
                {
                    quadrante = "Eixo Y";
                }
                else
                {
                    quadrante = "Eixo X";
                }
            }

            Console.WriteLine(quadrante);
        }
    }

    public class Ex8
    {
        static public void Imposto()
        {
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string saida;

            double taxaFaixa2 = (3000 - 2000) * 0.08;
            double taxaFaixa3 = (4500 - 3000) * 0.18;

            if(salario <= 2000)
            {
                saida = "Isento";
            }
            else if (salario <= 3000)
            {
                saida = $"R$ {((salario - 2000) * 0.08).ToString("F2", CultureInfo.InvariantCulture)}";
            }
            else if (salario <= 4500)
            {
                saida = $"R$ {(taxaFaixa2 + ((salario - 3000) * 0.18)).ToString("F2", CultureInfo.InvariantCulture)}";
            }
            else
            {
                saida = $"R$ {(taxaFaixa2 + taxaFaixa3 + ((salario - 4500) * 0.28)).ToString("F2", CultureInfo.InvariantCulture)}";
            }

            Console.WriteLine($"{saida}");
        }
    }
}
