using Ejercicio_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    public class Cuenta
    {	//Declaro atributos de clase
        double iSaldo;
        double iAcuerdo;

	//Declaro constructores
        public Cuenta(double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = 0;
        }

        public Cuenta(double pSaldoInicial, double pAcuerdo)
        {
            this.iAcuerdo = pAcuerdo;
            this.iSaldo = pSaldoInicial;
        }
	//Declaro propiedades que retornan el valor de los atributos de clase
        public double Saldo
            {
               get{ return this.iSaldo; }
            }
        public double Acuerdo
        {
            get { return this.iAcuerdo; }
        }
	//Declaro metodo que acredita saldo a una cuenta, el monto es pasado por parámetro, si el monto es un numero negativo
    //se laza una excepción SaldoNegativo, o si el saldo a acreditar es 0, tambien se lanza una excepción. 
        public void AcreditarSaldo(double pSaldo)
        {
            if (pSaldo < 0)
            {
                throw new SaldoNegativo();
            }

            if (pSaldo == 0)
            {
                throw new ArgumentException();
            }
            this.iSaldo = this.iSaldo + pSaldo;
        }
        //Declaro metodo que debita saldo a una cuenta, el monto es pasado por parámetro. 
        //Si el usuario tiene saldo suficiente, se debitará el monto, en caso contrario, el proceso se corta y se ñanza una excepción.
        public bool DebitarSaldo(double pSaldo)
        {
            if (this.Saldo + iAcuerdo < pSaldo )
            {
                throw new SaldoInsuficiente();
            }



            this.iSaldo = this.iSaldo - pSaldo;


            return true;
                     
            
            
        }
    }
}
