using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorx = 0;
            Random aleatorio = new Random();
            while (valorx <= 62580)
            {
                
                int valor1 = aleatorio.Next(1, 25);
                int valor2 = aleatorio.Next(1, 25);
                int valor3 = aleatorio.Next(1, 25);
                int valor4 = aleatorio.Next(1, 25);
                int valor5 = aleatorio.Next(1, 25);
                int valor6 = aleatorio.Next(1, 25);
                int valor7 = aleatorio.Next(1, 25);
                int valor8 = aleatorio.Next(1, 25);
                int valor9 = aleatorio.Next(1, 25);
                int valor10 = aleatorio.Next(1, 25);
                int valor11 = aleatorio.Next(1, 25);
                int valor12 = aleatorio.Next(1, 25);
                int valor13 = aleatorio.Next(1, 25);
                int valor14 = aleatorio.Next(1, 25);
                int valor15 = aleatorio.Next(1, 25);
                int total = valor1 + valor2 + valor3 + valor4 + valor5 + valor6 + valor7 + valor8 + valor9 + valor10 + valor11 + valor12 + valor13 + valor14 + valor15;

                Console.WriteLine($"{valor1} {valor2} {valor3} {valor4} {valor5} {valor6} {valor7} {valor8} {valor9} {valor10} {valor11} {valor12} {valor13} {valor14} {valor15}");

                

                valorx++;

            }
            Console.ReadLine();
        }
    }
}
