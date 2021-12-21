using System;
using System.Globalization;

namespace ExercicioFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Retangulo retangulo = new Retangulo();

            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {retangulo.Area().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal().ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
