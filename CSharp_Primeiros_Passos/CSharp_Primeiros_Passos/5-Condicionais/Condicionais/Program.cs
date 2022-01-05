using System;
using System.Collections.Generic;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Testando condicionais");

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado = quantidadePessoas >= 2;

            if (idade >= 18 && acompanhado)
            {
                Console.WriteLine("Você tem mais de 18 anos");
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("Infelizmente você não pode entrar!");
            }

            Console.WriteLine("A execução acabou. Tecle enter para sair . . . ");
            Console.ReadLine();
        }
    }
}
