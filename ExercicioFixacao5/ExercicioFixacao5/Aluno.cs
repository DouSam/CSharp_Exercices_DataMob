using System;

namespace ExercicioFixacao5
{
    class Aluno
    {
        public string Nome;
        public double[] Notas = {0, 0, 0};
        public double NotaFinal()
        {
            return Notas[0] + Notas[1] + Notas[2];
        }
        public string Situacao()
        {
            if(NotaFinal() >= 60)
            {
                return "APROVADO";
            }
            else
            {
                return "REPROVADO";
            }
        }
        public double DiferencaNotaCorte()
        {
            return 60 - NotaFinal();
        }
    }
}
