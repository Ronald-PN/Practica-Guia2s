using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaGuia2_ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMPRIMIR LOS MULTIPLOS DE 3, DEL 1 AL 200");
            Console.WriteLine("___________________________________________");
            int a = 3;
            while (a<=200)
            {
                Console.WriteLine(a);
                a=a+3;
         
           }
            Console.ReadKey();
        }
    }
}