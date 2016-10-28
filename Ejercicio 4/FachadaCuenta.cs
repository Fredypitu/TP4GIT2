using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class FachadaCuenta
    {	//Instancio una clase
        private Cuentas iCuentas = new Cuentas();
	//Declaro metodo que retorna el saldo de una cuenta corriente
        public double ConsultarSaldoCC()
        {
            return this.iCuentas.CuentaCorriente.Saldo;
        }

	//Declaro metodo que retorna el saldo de una caja de ahorro
        public double ConsultarSaldoCA()
        {
            return iCuentas.CajaAhorro.Saldo;
        }
	//Declaro metodo que retorna el saldo de un acuerdo de una cuenta corriente
        public double ConsultarAcuerdoCC()
        {
            return iCuentas.CuentaCorriente.Acuerdo;
        }
	//Declaro metodo que retorna el saldo de un acuerdo de una caja de ahorro
        public double ConsultarAcuerdoCA()
        {
            return iCuentas.CajaAhorro.Acuerdo;
        }
	//Declaro metodo que acredita un saldo pasado por parámetro a una cuenta corriente, retorna un 	valor de verdad (v o f) si se realizo la operacion
        public bool AcreditarSaldoCC(double pSaldo)
        {
            iCuentas.CuentaCorriente.AcreditarSaldo(pSaldo);
            return true;
        }
	//Declaro metodo que acredita un saldo pasado por parámetro a una caja ahorro, retorna un 		valor de verdad (v o f) si se realizo la operacion
        public bool AcreditarSaldoCA(double pSaldo)
        {
            iCuentas.CajaAhorro.AcreditarSaldo(pSaldo);
            return true;
        }
	//Declaro metodo que debita un saldo pasado por parámetro a una cuenta corriente, retorna un 		valor de verdad (v o f) si se realizo la operacion
        public bool DebitarSaldoCC(double pSaldo)
        {
            if (iCuentas.CuentaCorriente.DebitarSaldo(pSaldo))
            {
                return true;
            }
            else { return false; }
        }
	//Declaro metodo que debita un saldo pasado por parámetro a una caja ahorro, retorna un 			valor de verdad (v o f) si se realizo la operacion
        public bool DebitarSaldoCA(double pSaldo)
        {
            if (iCuentas.CajaAhorro.DebitarSaldo(pSaldo))
            {
                return true;
            }
            else { return false; }

        }
	//Declaro metodo que realiza un transferencia de un monto pasado por parámetro desde una cuenta corriente a una caja de ahorro, retorna un valor de verdad (v o f) si se realizo la operacion
        public bool TransferirDeCCaCA(double pMonto)
        {
            if (this.iCuentas.CuentaCorriente.DebitarSaldo(pMonto))
            {
                this.iCuentas.CajaAhorro.AcreditarSaldo(pMonto);
                return true;
            }
            else
            {
                return false;
            }
        }
	//Declaro metodo que realiza un transferencia de un monto pasado por parámetro desde una caja de ahorro a una cuenta corriente, retorna un valor de verdad (v o f) si se realizo la operacion
        public bool TransferirDeCAaCC(double pMonto)
        {
            if (this.iCuentas.CajaAhorro.DebitarSaldo(pMonto))
            {
                this.iCuentas.CuentaCorriente.AcreditarSaldo(pMonto);
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
