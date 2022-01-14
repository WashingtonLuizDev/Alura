using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Titular = "Gabriela";

            Console.WriteLine($"Titular: {conta.Titular}");
            Console.WriteLine($"Agência: {conta.Agencia}");
            Console.WriteLine($"Número: {conta.Numero}");
            Console.WriteLine($"Saldo: {conta.Saldo}");

            Console.WriteLine("O Sistema está sendo encerrado, aperte enter para sair...");
            Console.ReadLine();
        }
    }
}
