using System;

namespace ExerciciosPropostos3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1.Senha();
            //Ex2.Quadrante();
            Ex3.Preferencia();
        }
    }

    public class Ex1
    {
        static public void Senha()
        {
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }

    public class Ex2
    {
        static public void Quadrante()
        {
            string[] entrada = Console.ReadLine().Split(" ");

            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            string quadrante = verificaQuadrante(x, y);

            while (quadrante != " ")
            {
                Console.WriteLine(quadrante);
                entrada = Console.ReadLine().Split(" ");

                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);

                quadrante = verificaQuadrante(x,y);
            }
        }

        static public string verificaQuadrante(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return "Primeiro";
            }
            else if (x < 0 && y > 0)
            {
                return "Segundo";
            }
            else if (x < 0 && y < 0)
            {
                return "Terceiro";
            }
            else if (x > 0 && y < 0)
            {
                return "Quarto";
            }
            else
            {
                return " ";
            }
        }
    }

    public class Ex3
    {
        static public void Preferencia()
        {
            int totalA = 0;
            int totalG = 0;
            int totalD = 0;
            int opcao = 0;

            do
            {
                opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    totalA++;
                }
                else if (opcao == 2)
                {
                    totalG++;
                }
                else if (opcao == 3)
                {
                    totalD++;
                }
            } while (opcao != 4);

            Console.WriteLine($"MUITO OBRIGADO\nAlcool: {totalA}\nGasolina: {totalG}\nDiesel: {totalD}");
        }
    }
}
