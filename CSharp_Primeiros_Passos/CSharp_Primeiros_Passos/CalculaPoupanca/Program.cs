using System;

namespace CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * (0.36 / 100);
                Console.WriteLine($"Após {contadorMes} meses, você terá R$ {Math.Round(valorInvestido,2)}");
                contadorMes++;
            }

            Console.ReadLine();
        }
    }
}
