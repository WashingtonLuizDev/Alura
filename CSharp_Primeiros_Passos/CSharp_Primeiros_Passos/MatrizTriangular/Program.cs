using System;

namespace MatrizTriangular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 17 - Matriz Triangular");

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadLine();
        }
    }
}
