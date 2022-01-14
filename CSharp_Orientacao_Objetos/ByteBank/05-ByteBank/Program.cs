using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.Nome = "Gabriela";
            //gabriela.Profissao = "Desenvolvedora C#";
            //gabriela.CPF = "414.597.998-28";

            ContaCorrente conta = new ContaCorrente();

            //conta.Titular = gabriela;
            conta.Titular = new Cliente();
            conta.Titular.Nome = "Gabriela";
            conta.Titular.Profissao = "Desenvolvedora C#";
            conta.Titular.CPF = "414.597.998-28";

            conta.Agencia = 7867;
            conta.Numero = 078961;
            conta.Depositar(1000);

            if (conta.Titular == null) {
                Console.WriteLine("Não foi instaciado nenhum Titular.");
            }
            else
            {
                Console.WriteLine($"Nome.....: {conta.Titular.Nome}\nProfissão: {conta.Titular.Profissao}\nCPF......: {conta.Titular.CPF}");
                Console.WriteLine($"Agencia..: {conta.Agencia}\nNúmero...: {conta.Numero}");
            }

            ContaCorrente contaDaCamila = new ContaCorrente();

            contaDaCamila.Titular = new Cliente()
            {
                Nome = "Camila",
                CPF = "413.556.098-95",
                Profissao = "Analista Operacional"
            };

            if (contaDaCamila.Titular == null)
            {
                Console.WriteLine("Não foi instaciado nenhum Titular.");
            }
            else
            {
                Console.WriteLine($"Nome.....: {contaDaCamila.Titular.Nome}\nProfissão: {contaDaCamila.Titular.Profissao}\nCPF......: {contaDaCamila.Titular.CPF}");
                Console.WriteLine($"Agencia..: {contaDaCamila.Agencia}\nNúmero...: {contaDaCamila.Numero}");
            }


            Console.WriteLine("O Sistema está sendo encerrado, aperte enter para sair...");
            Console.ReadLine();
        }
    }
}
