using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Cuentas
    {	//Declaro variables de clase
       private Cuenta iCuentaCorriente;
       private Cuenta iCajaAhorro;
       private Cliente iCliente;
	//Declaro metodo que instancian clases
        public Cuentas()
        {
            this.iCuentaCorriente = new Cuenta(2000);
            this.iCajaAhorro = new Cuenta(1000);
            this.iCliente = new Cliente();
        }
	//Declaro propiedades que retornan los valores de los atributos de clase
        public Cuenta CuentaCorriente
        {
            get { return this.iCuentaCorriente; }
        }

        public Cuenta CajaAhorro
        {
            get { return this.iCajaAhorro; }
        }

    }
}
