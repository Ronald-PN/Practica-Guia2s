using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGuia_ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESAR N NUMEROS POR EL TECLADO Y DECIR LA CANTIDAD PARES, IMPARES, POSITIVO Y NEGATIVO");
            Console.WriteLine("_______________________________________________________________________________________________");
            int N=0, pares=0, impares=0, negativo=0, positivo=0,  t=0;
            Console.WriteLine("ingrese la cantidad de numeres determinados");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i<= N; i++)
            {
         Console.WriteLine("INGRESE EL NUMERO " + i);
                t = Convert.ToInt32(Console.ReadLine());

               


        }

            if (t% 2==0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }

              if (t>0)
                {
                positivo = positivo + 1;
                }
            else
            {
                negativo = negativo + 1;
            }
            
           Console.WriteLine("PARES: " + pares);
            Console.WriteLine("IMPARES: " + impares);
            Console.WriteLine("POSITIVO: " + positivo);
            Console.WriteLine("NEGATIVO: " + negativo);
            Console.ReadKey();
        }
           

    }
}

        