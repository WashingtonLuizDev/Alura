using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(867, 86712540);

            Console.WriteLine($"Número da Conta {conta.Numero}");
            Console.WriteLine($"Agencia da Conta {conta.Agencia}");

            ContaCorrente contaDoWashington = new ContaCorrente(7867, 078961);

            Console.WriteLine($"Número da Conta {contaDoWashington.Numero}");
            Console.WriteLine($"Agencia da Conta {contaDoWashington.Agencia}");

            Console.WriteLine($"Total de contas criadas:S {ContaCorrente.TotalDeContasCriadas}");
            Console.WriteLine("O Sistema está sendo encerrado, aperte enter para sair...");
            Console.ReadLine();
        }
    }
}
