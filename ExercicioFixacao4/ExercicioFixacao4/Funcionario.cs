using System.Globalization;

namespace ExercicioFixacao4
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto *= ((porcentagem / 100) + 1);
        }
        public override string ToString()
        {
            return $"Funcionário: {Nome}, $ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
