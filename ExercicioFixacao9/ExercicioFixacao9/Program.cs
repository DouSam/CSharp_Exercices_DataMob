using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioFixacao9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int auxId;
            List<Funcionario> funcionarios = new List<Funcionario>();
            Funcionario auxFunc;
            Console.Write("Quantos empregados serão registrados? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string auxNome;
                double auxSalario;

                Console.WriteLine($"\nEmpregado #{i + 1}: ");

                do
                {
                    Console.Write("Id: ");
                    auxId = int.Parse(Console.ReadLine());
                    auxFunc = funcionarios.Find(x => x.Id == auxId);
                    if (auxFunc != null)
                    {
                        Console.WriteLine("ID já cadastrado.");
                    }
                } while (auxFunc != null);

                Console.Write("Nome: ");
                auxNome = Console.ReadLine();

                Console.Write("Salario: ");
                auxSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionarios.Add(new Funcionario(auxId,auxNome,auxSalario));
            }

            Console.Write("\nInsira o ID do funcio que terá o salário aumentado: ");
            auxId = int.Parse(Console.ReadLine());
            auxFunc = funcionarios.Find(x => x.Id == auxId);
            if (auxFunc != null)
            {
                double perc;
                Console.Write("Qual o percentual: ");
                perc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                auxFunc.Aumento(perc);
            }
            else
            {
                Console.WriteLine("O ID inserido não existe.");
            }

            Console.WriteLine("\nLista atualizada de funcionarios.");

            foreach (Funcionario func in funcionarios)
            {
                Console.WriteLine(func);
            }
        }
    }
}
