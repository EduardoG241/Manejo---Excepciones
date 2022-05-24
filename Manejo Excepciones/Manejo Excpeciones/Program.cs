using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Ingrese un numero entero: ");
            try
            {
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(num1,2));
                Console.Write("Presione enter para cerrar...");
                Console.ReadKey();
            }
            catch(FormatException )
            {
                Console.WriteLine("El numero ingresado no es un numero entero.");
                Console.Write("Presione enter para salir...");
                Console.ReadKey();
            }
            catch (OverflowException)
            {
                Console.WriteLine("El numero ingresado es demasiado grande.");
                Console.Write("Presione enter para salir...");
                Console.ReadKey();
            }
        }
    }
}
