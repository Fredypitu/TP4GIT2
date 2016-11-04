using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
   public class Matematica
    {
        public Matematica()
        {

        }

        public double Dividir(int pDivisor, int pDividendo)
        {
            if (pDividendo==0)
            {
                throw new DivisionPorCeroExcepcion();
            }

            return pDivisor / pDividendo;

        }

    }
}
