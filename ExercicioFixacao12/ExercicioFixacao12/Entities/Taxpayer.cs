using System.Globalization;

namespace ExercicioFixacao12.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        abstract public double Tax();

        public override string ToString()
        {
            return $"{Name}: $ {Tax().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
