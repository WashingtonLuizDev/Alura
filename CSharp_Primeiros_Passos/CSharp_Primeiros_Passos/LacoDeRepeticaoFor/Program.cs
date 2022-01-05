using System;

namespace LacoDeRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 15 - Laço De Repetição For");

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }

            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadLine();
        }
    }
}
