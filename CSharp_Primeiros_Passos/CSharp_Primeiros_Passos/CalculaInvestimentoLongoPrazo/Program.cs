using System;

namespace CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 12 - Calcula Investimento Longo Prazo");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine($"Ao Término do Investimento, você terá R$ {Math.Round(valorInvestido, 2)}");

            Console.ReadLine();
        }
    }
}
