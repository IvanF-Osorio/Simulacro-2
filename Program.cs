using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = dado2 + dado1, suma = 0, totales6 = 0, dobles = 0;
            string continuar = "s";

            while (continuar == "s" && (dado1 != 1 || dado2 != 1))
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                suma = dado2+dado1;
                total += dado1 + dado2;
                Console.WriteLine("primer dado =" + dado1);
                Console.WriteLine("segundo dado =" + dado2);
                Console.WriteLine("la suma es =" + suma);
               
                    if (dado1 == 1 && dado2 == 1)
                    {
                        total = 0;
                        Console.WriteLine("dobles = " + dobles);
                    }
                    else if (total >= 100)
                    {
                        Console.WriteLine("Gano");
                        continuar = "n";
                    }
                    else
                    {

                        Console.WriteLine("total = " + total);
                        Console.Write("Desea continuar (s/n):");
                        continuar = Console.ReadLine();

                    }
                
                
            }

            Console.WriteLine("Gracias por participar");
            Console.WriteLine("su total fue =" + total + " puntos");
        }
    }
}
