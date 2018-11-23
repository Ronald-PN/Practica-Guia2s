using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGuia2_ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EVALUAR OPERARIO SEGUN SU SUELDO Y ANTIGUEDAD");
            double sueldo=0, antiguedad, aumento;
            Console.WriteLine("________________________________________________");
            Console.WriteLine("DE CUANTO ES EL SUELDO?");
            sueldo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("________________________________________________");
            Console.WriteLine("CUATO TIEMPO TIENE TRABAJANDO?");
           antiguedad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("________________________________________________");
            if (sueldo<500 && antiguedad>=10)
            {
                aumento = sueldo * 0.20 + sueldo;
                Console.WriteLine("SU NUEVO SUELDO ES DE: " + aumento);
            }
            else if (sueldo <500 && antiguedad < 10)
            {
                aumento = sueldo * 0.05 + sueldo;
                Console.WriteLine("SU NUEVO SUELDO ES DE: " + aumento);
            }
            if (sueldo >= 500 )
            {
                aumento = sueldo;
                Console.WriteLine("NO APLICA PARA AUMENTO");
            }
          

            Console.ReadKey();
        }
    }
}

 

  


