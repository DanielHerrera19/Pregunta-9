using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pregunta_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de rangos");
            Console.WriteLine("Ingrese la cantidad de sus puntos: ");
            int puntos = int.Parse(Console.ReadLine());
            string rango;

            if (puntos >= 999) 
            {
                rango = "Bronce";
            }
            else if (puntos >= 4999)
            {
                rango = "Plata";
            }
            else if (puntos >= 9999)
            {
                rango = "Oro";
            }
            else if (puntos >= 10000)
            {
                rango = "Platino";
            }
            else
            {
                rango = "Ingrese un numero valido de puntos";
            }
            
            Console.WriteLine("Usted se encuentra en el rango: " + rango);
            Console.ReadKey();
        }
    }
}