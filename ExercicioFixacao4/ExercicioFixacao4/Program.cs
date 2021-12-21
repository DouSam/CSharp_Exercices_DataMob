using System;
using System.Globalization;

namespace ExercicioFixacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(funcionario);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(funcionario);
        }
    }
}
