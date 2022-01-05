using System;

namespace Multiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 18 - Multiplos");

            for (int contador = 1; contador < 100; contador++)
            {
                if (contador % 3 == 0)
                {
                    Console.WriteLine($"O número {contador} é múltiplo de 3.");
                    Console.WriteLine();
                }
            }

            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadLine();
        }
    }
}
