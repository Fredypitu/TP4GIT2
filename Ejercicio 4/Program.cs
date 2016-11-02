using Ejercicio_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {	//Declaro variables tipo string constantes
        private const string CC = "CC"; //Cuenta Corriente
        private const string CA = "CA"; //Caja de Ahorro

        static void Main(string[] args)
        {
            
            string opCuenta="";
            
            do
            {
                opCuenta = MenuCuentas();

                if (opCuenta=="1") // CAJA DE AHORRO
                {
                    OperarCuenta(CA);//CA: Const que representa Caja de Ahorro
                }
                else if(opCuenta=="2") // CUENTA CORRIENTE
                {
                    OperarCuenta(CC); //CC: Const que represnt Cuenta Corriente
                }
                else if(opCuenta=="3")//SALE DEL PROGRAMA
                {
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("NO EXISTE OPCION SELECCIONADA");
                }

            } while (opCuenta!="3");

        }

	//Declaro menu seleccion de operaciones a realizar
        private static string MenuOperaciones()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("SELECCIONAR UNA OPERACION");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1- CONSULTAR SALDO");
            Console.WriteLine("2- CONSULTAR PREMIO");
            Console.WriteLine("3- REALIZAR EXTRACCION");
            Console.WriteLine("4- INGRESAR SALDO");
            Console.WriteLine("5- REALIZAR TRANSFERENCIA DE CC A CA");
            Console.WriteLine("6- REALIZAR TRANSFERENCIA DE CA A CC");
            Console.WriteLine("7- SALIR");
            Console.WriteLine("");
            Console.Write("OPCION: ");
            return Console.ReadLine();
        }
	//Declaro menu seleccion del tipo de cuenta
        private static string MenuCuentas()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("SELECCIONAR CUENTA");
            Console.WriteLine("----------------------------");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1- CAJA DE AHORRO");
            Console.WriteLine("2- CUENTA CORRIENTE");
            Console.WriteLine("3- SALIR");
            Console.WriteLine("");
            Console.Write("OPCION: ");
            return Console.ReadLine();
        }
	//Declaro metodo que instancia una clase y el usuario debe seleccionar el tipo de operacion a realizar dentro del menu
        private static void OperarCuenta(string pTipoCuenta)
        {
            FachadaCuenta iFC = new FachadaCuenta();
            string opOperacion = "";
            
            do
            {
                
               opOperacion = MenuOperaciones();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;

                switch (opOperacion)
                {
                    case "1": //CONSULTAR SALDOO
                        if (pTipoCuenta=="CC")
                        {
                            Console.WriteLine("SALDO: " + iFC.ConsultarSaldoCC());
                        }
                        else
                        {
                            Console.WriteLine("SALDO: " + iFC.ConsultarSaldoCA());
                        }
                        Console.ReadKey();
                        break;
                    case "2": //----CONSULTAR PREMIO ------------------------------------------------
                        if (pTipoCuenta == "CC")
                        {
                            Console.WriteLine("EL ACUERDO ES POR: " + iFC.ConsultarAcuerdoCC());
                        }
                        else
                        {
                            Console.WriteLine("EL ACUERDO ES POR: " + iFC.ConsultarAcuerdoCA());
                        }
                        Console.ReadKey();
                        break;

                    case "3": //---- REALIZAR EXTRACCION --------------------------------------------

                        
                        Console.Write("MONTO A EXTRAER: ");
                        double monto = Convert.ToDouble(Console.ReadLine());

                        if (pTipoCuenta == "CC")
                        {
                            try
                            {
                                iFC.DebitarSaldoCC(monto);
                                Console.WriteLine("OPERACION REALIZADA EXITOSAMENTE");
                            }
                            catch (SaldoInsuficiente)
                            {
                                Console.WriteLine("OPERACION NO REALIZADA");
                            }
                           
                        }
                        else
                        {
                            try
                            {
                                iFC.DebitarSaldoCA(monto);
                                Console.WriteLine("OPERACION REALIZADA EXITOSAMENTE");
                            }
                            catch (SaldoInsuficiente)
                            {

                                Console.WriteLine("OPERACION NO REALIZADA");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case "4": //---- INGRESAR SALDO -------------------------------------------------

                        
                        Console.Write("MONTO A DEPOSITAR: ");
                        monto = Convert.ToDouble(Console.ReadLine());

                        if (pTipoCuenta == "CC")
                        {
                            try
                            {
                                iFC.AcreditarSaldoCC(monto);
                                Console.WriteLine("OPERACION REALIZADA EXITOSAMENTE");
                            }
                            catch (SaldoNegativo)
                            {
                                Console.WriteLine("EL SALDO NO PUEDE SER NEGATIVO");
                            }
                           
                        }
                        else
                        {
                            {
                                try 
                                {
                                    iFC.AcreditarSaldoCA(monto);
                                    Console.WriteLine("OPERACION REALIZADA EXITOSAMENTE");
                                }
                                catch (ArgumentException) 
                                {
                                    Console.WriteLine("EL SALDO NO PUEDE SER 0");
                                }
                                catch (SaldoNegativo)
                                {
                                    Console.WriteLine("EL SALDO NO PUEDE SER NEGATIVO");
                                }

                            }
                        }

                        break;
                    case "5": //TRANSFERENCAIA CC a CA

                     
                        Console.Write("MONTO A TRANSFERIR: ");
                        monto = Convert.ToDouble(Console.ReadLine());
                        if (iFC.TransferirDeCCaCA(monto))
                        {
                            Console.WriteLine("TRANSFERENCIA REALIZADA");
                        }
                        else
                        {
                            Console.WriteLine("NO SE REALIZO LA TRANSFERENCIA");
                        }
                        Console.ReadKey();
                        break;
                    case "6": //TRANSFERENCAIA CA a CC
                        
                    
                        Console.Write("MONTO A TRANSFERIR: ");
                        monto = Convert.ToDouble(Console.ReadLine());
                        if (iFC.TransferirDeCAaCC(monto))
                        {
                            Console.WriteLine("TRANSFERENCIA REALIZADA");
                        }
                        else
                        {
                            Console.WriteLine("NO SE REALIZO LA TRANSFERENCIA");
                        }
                        Console.ReadKey();
                        break;

                    case "7": //SALIR
                        break;

                    default:
                        Console.WriteLine("INGRESE UNA OPCION VALIDA");
                        Console.ReadKey();
                        break;
                }

            } while (opOperacion!="7");

        }

     

        }

 
}

