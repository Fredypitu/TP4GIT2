using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{
    class Program
    {
        static void Main(string[] args)
        {
            FachadaMatematicas fMat = new FachadaMatematicas();
            int iDividendo, iDivisor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("OPERACION DIVISION");
            Console.WriteLine("----------------------------------");
            Console.WriteLine(" ");

            Console.Write("Ingrese NUMERADOR: ");
            iDivisor =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            Console.Write("Ingrese DENOMINADOR: ");
            iDividendo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("La Division es:  ",Convert.ToString(fMat.Dividir(iDivisor,iDividendo)));
            }
            catch (DivisionPorCeroExcepcion)
            {
                Console.WriteLine("El DIVIDENDO debe ser distinto de 0");
                
            }
            finally
            {
                Console.ReadKey();
            }
            

            




        }
    }
}
