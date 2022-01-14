using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.Titular = "Gabriela";
            contaDaGabriela.Agencia = 7867;
            contaDaGabriela.Numero = 78961;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.Titular = "Gabriela";
            contaDaGabrielaCosta.Agencia = 7867;
            contaDaGabrielaCosta.Numero = 78961;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine("Após atribuir a referencia entre objetos comparamos um com o outro novamente o resultado é: " + (contaDaGabriela == contaDaGabrielaCosta));

            contaDaGabriela.Saldo = 300;
            Console.WriteLine($"Saldo da conta da Gabriela:{contaDaGabriela.Saldo}");
            Console.WriteLine($"Saldo da conta da Gabriela Costa: {contaDaGabrielaCosta.Saldo}");

            Console.WriteLine("O Sistema está sendo encerrado, aperte enter para sair...");
            Console.ReadLine();
            
        }
    }
}
