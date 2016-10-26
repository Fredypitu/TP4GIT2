using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4GIT
{
    // probandooooooooooooooooooooooooooooooooo
  public class CapaAplicacion
    {
       public CapaAplicacion()
        {
        }

        public void Ejecutar()
        {
            try
            {
                new CapaDominio().Ejecutar();
            }
            catch (ErrorPuntualException)
            {
                throw new CapaAplicacionException();
            }
        }
    }
}
