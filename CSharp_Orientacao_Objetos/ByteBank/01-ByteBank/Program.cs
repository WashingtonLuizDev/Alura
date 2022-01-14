using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();

            primeiraContaCorrente.Saldo = 200;

            Console.WriteLine($"O Saldo da conta corrente é: {primeiraContaCorrente.Saldo.ToString("C")}");

            primeiraContaCorrente.Saldo += 100;

            Console.WriteLine($"O Saldo da conta corrente após aporte é: {primeiraContaCorrente.Saldo.ToString("C")}");

            ContaCorrente segundaContaCorrente = new ContaCorrente();

            segundaContaCorrente.Saldo = 50;

            Console.WriteLine($"primeira conta tem {primeiraContaCorrente.Saldo.ToString("C")}!");
            Console.WriteLine($"segunda conta tem {segundaContaCorrente.Saldo.ToString("C")}!");

            Console.WriteLine();

            Console.WriteLine("O Sistema está sendo encerrado, aperte enter para sair...");
            Console.ReadLine();
        }
    }
}
