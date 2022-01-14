using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = new Cliente()
            {
                Nome = "Washington",
                CPF = "414.597.998-28",
                Profissao = "Desenvolvedor C#"
            };

            conta.Saldo = -10;

            Console.WriteLine($"Saldo {conta.Saldo}");
            Console.WriteLine($"Titular: {conta.Titular.Nome}");

            Console.WriteLine("O Sistema está sendo encerrado, aperte enter para sair...");
            Console.ReadLine();
        }
    }
}
