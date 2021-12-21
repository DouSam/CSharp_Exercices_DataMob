using System;
using System.Globalization;

namespace ExercicioFixacao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");

            for (int i = 0; i < 3; i++)
            {
                aluno.Notas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine($"NOTA FINAL = {aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(aluno.Situacao());
            if(aluno.Situacao() == "REPROVADO")
            {
                Console.WriteLine($"FALTARAM {aluno.DiferencaNotaCorte().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}
