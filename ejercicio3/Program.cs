using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ejercicio3
{
    class Program
    {
       static void Main(string[] args)
        {
           
                Console.WriteLine("Ingrese Ruta");
                 string iRuta = Console.ReadLine();
                 string mostrar;
               try
                {
                    StreamReader leer = new StreamReader(@iRuta);
                    while ((mostrar = leer.ReadLine()) != null)
                    {
                        Console.WriteLine(mostrar);
                    }
                    leer.Close();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("No se encontro el archivo");
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("No se encontro el directorio");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("no se ha proporcionado Ruta");
                }
                catch (IOException)
                {
                    Console.WriteLine("ruta mal escrita");
                }
                Console.ReadKey();
                }
    }
}
