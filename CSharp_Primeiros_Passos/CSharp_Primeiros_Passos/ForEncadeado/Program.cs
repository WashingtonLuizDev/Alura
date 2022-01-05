using System;

namespace ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 13 - For Encadeado");

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    Console.Write("*");
                    if (coluna >= linha)
                        break;
                }
                Console.WriteLine("");
            }

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <= linha; coluna++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadLine();
        }
    }
}
