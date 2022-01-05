using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 16 - Tabuada");

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadLine();
        }
    }
}
