using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDoBruno = new ContaCorrente();
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDoBruno.Titular = "Bruno";
            contaDaGabriela.Titular = "Gabriela";

            Console.WriteLine($"Olá {contaDoBruno.Titular} o saldo da sua conta é: {contaDoBruno.Saldo.ToString("C")}");

            if (contaDoBruno.Sacar(50))
            {
                Console.WriteLine($"Saque Efetuado com sucesso seu novo saldo é: {contaDoBruno.Saldo.ToString("C")}");
            }
            else {
                Console.WriteLine($"Saldo insuficiente. Verifique o saldo e tente novamente.");
            }

            contaDoBruno.Depositar(100);

            Console.WriteLine($"Após o depósito o saldo do {contaDoBruno.Titular} é de: {contaDoBruno.Saldo.ToString("C")}");

            Console.WriteLine($"Saldo Conta do {contaDoBruno.Titular} é de: {contaDoBruno.Saldo}");
            Console.WriteLine($"Saldo Conta do {contaDaGabriela.Titular} é de: {contaDaGabriela.Saldo}");

            Console.WriteLine($"O {contaDoBruno.Titular} irá transferir R$1000,00 para a {contaDaGabriela.Titular}");
            if (contaDoBruno.Transferir(1000, contaDaGabriela))
            {
                Console.WriteLine($"Transferencia Efetuada com sucesso o saldo do {contaDoBruno.Titular} é: {contaDoBruno.Saldo.ToString("C")}");
                Console.WriteLine($"Transferencia Efetuada com sucesso o saldo da {contaDaGabriela.Titular} é: {contaDaGabriela.Saldo.ToString("C")}");
            }
            else
            {
                Console.WriteLine($"Saldo insuficiente. Verifique o saldo e tente novamente.");
            }

            Console.WriteLine("O Sistema está sendo encerrado, aperte enter para sair...");
            Console.ReadLine();
        }
    }
}
