using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 19 - Desafio Fatorial");

            string contaFatorial = "";
            int resultado = 0;
            int contador = 0;

            for (int fatorial = 1; fatorial < 6; fatorial++)
            {
                if (fatorial == 1)
                {
                    resultado = fatorial * (fatorial + 1);
                }
                else {
                    resultado = resultado * (fatorial + 1);
                }
                contaFatorial = contaFatorial + fatorial + "x";
                contador++;
            }
            contador++;
            contaFatorial = contaFatorial + contador + "=" + resultado;
            Console.WriteLine($"{contaFatorial}");
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadLine();
        }
    }
}
