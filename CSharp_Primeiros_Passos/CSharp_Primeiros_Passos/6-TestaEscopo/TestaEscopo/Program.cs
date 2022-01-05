using System;

namespace TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6 - Testando escopo");

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado = true;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
            }
            else {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja Bem Vindo!");
            }
            else {
                Console.WriteLine("Infelizmente você não pode entrar!");
            }

            Console.WriteLine("A execução acabou. Tecle enter para sair . . . ");
            Console.ReadLine();
        }
    }
}
