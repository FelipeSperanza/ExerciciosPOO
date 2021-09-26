using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class ConversorDeMoeda
    {
        public static double ValorPago(double cota, double dol)
        {
            return (cota * dol * 0.06) + (cota*dol);
        }
    }
}
