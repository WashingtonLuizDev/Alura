using System;

namespace CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula poupança");

            double valorInvestido = 1000;

            for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine($"Após {contadorMes} meses, você terá R$ {Math.Round(valorInvestido,2)}");
            }

            Console.ReadLine();
        }
    }
}
