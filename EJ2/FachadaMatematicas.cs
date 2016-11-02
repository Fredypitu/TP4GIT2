using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class FachadaMatematicas
    {
        Matematica mat = new Matematica();

        public double Dividir(int pDivisor, int pDividendo)
        {
            return mat.Dividir(pDivisor, pDividendo);
        }
    }
}
