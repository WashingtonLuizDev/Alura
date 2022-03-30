using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta = new ContaCorrente(7480, 874150);

            //Console.WriteLine(ContaCorrente.TaxaOperacao);

            try
            {
                Metodo();
            }
            catch (NullReferenceException excecao)
            {
                Console.WriteLine($"{excecao.Message}");
                Console.WriteLine($"{excecao.StackTrace}");
                Console.WriteLine($"Aconteceu um erro!");
            }
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Não é possível fazer uma divisão por 0!");
            }

            Console.ReadLine();
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Exceção com numero = {numero} e divisor = {divisor}");
                throw;
            }
        }

        static void Metodo()
        {
            TestaDivisao(0);
        }

        static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine($"O Resultado da divisão de 10 por {divisor} é {resultado}");
        }

    }
}
