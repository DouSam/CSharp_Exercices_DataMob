namespace ExercicioFixacao12.Entities
{
    class Company : Taxpayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(int numberOfEmployees, string name, double anualIncome) : base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = (NumberOfEmployees > 10) ? AnualIncome * 0.14 : AnualIncome * 0.16;
            return tax;
        }
    }
}
