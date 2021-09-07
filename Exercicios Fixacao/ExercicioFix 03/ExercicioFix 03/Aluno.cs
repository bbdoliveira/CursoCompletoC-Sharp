using System;
using System.Globalization;

namespace ExercicioFix_03
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double MediaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        
        public bool Aprovado()
        {
            if (MediaFinal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - MediaFinal();
            }
        }
    }
}
