using System;

namespace ExercicioFixacao8
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Quarto[] quartos = new Quarto[10]; 
            string auxNome;
            string auxEmail;
            int quarto;

            Console.Write("Quantos quartos serão alugados? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\nAluguel #{i+1}:");
                Console.Write("Nome: ");
                auxNome = Console.ReadLine();
                Console.Write("Email: ");
                auxEmail = Console.ReadLine();
                Console.Write("Quarto: ");
                quarto = int.Parse(Console.ReadLine());

                quartos[quarto] = new Quarto(auxNome,auxEmail);
            }

            Console.WriteLine("\nQuartos ocupados: ");

            for (int i = 0; i < quartos.Length; i++)
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine($"{i + 1}: {quartos[i]}");
                }
            }
        }
    }
}
