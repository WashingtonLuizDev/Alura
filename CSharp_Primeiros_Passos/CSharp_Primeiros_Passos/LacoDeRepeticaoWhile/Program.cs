using System;

namespace LacoDeRepeticaoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 14 - Laço De Repetição While");

            int contador = 0;

            while (contador<=10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadLine();
        }
    }
}
