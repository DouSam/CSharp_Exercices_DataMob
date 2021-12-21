namespace ExercicioFixacao6
{
    class ConversorDeMoeda
    {
        public static double iof = 1.06;

        public static double Conversor(double cotacao, double quantidade)
        {
            return cotacao * quantidade * iof;
        }
    }
}
