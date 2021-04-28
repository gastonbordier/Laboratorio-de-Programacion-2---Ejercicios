using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auxiliar
{
    class Auxiliares
    {
        public static double TruncarEnDosDecimales(double numero)
        {
            int entero = 0;
            int primerDecimal = 0;
            int segundoDecimal = 0;

            entero = (int)numero;
            primerDecimal = (int)(numero* 10) - entero * 10;
            segundoDecimal = (int)(numero* 100) - entero * 100 - primerDecimal * 10;

            return entero + (double)primerDecimal / 10 + (double)segundoDecimal / 100;
        }
    }
}
