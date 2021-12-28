namespace ExercicioFixacao12.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = (AnualIncome < 20000) ? AnualIncome * 0.15: AnualIncome * 0.25;

            if (HealthExpenditures != 0)
            {
                tax -= (HealthExpenditures * 0.5);
            }

            return tax;
        }
    }
}
