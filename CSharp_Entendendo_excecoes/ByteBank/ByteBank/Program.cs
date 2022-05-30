using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();

            Console.WriteLine("Execução finalizada. Tecle enter para sair");
            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }
            //LeitorDeArquivo leitor = null;
            //try
            //{
            //    -------leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException capturada e tratada!");
            //}
            //finally {
            //    if(leitor != null)
            //        leitor.FecharArquivo();
            //}
            
        }

        private static void TestaInnerException()
        {
            try
            {
                ContaCorrente conta1 = new ContaCorrente(574, 123456789);
                ContaCorrente conta2 = new ContaCorrente(574, 987654321);

                //conta1.Transferir(10000, conta2);
                conta1.Sacar(10000);

                //conta1.Depositar(50);
                //Console.WriteLine(conta1.Saldo);
                //conta1.Sacar(-500);
                //Console.WriteLine(conta1.Saldo);
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);

                //Console.WriteLine("Informações da Inner Exception (exceção interna):");
                //Console.WriteLine(ex.InnerException.Message);
                //Console.WriteLine(ex.InnerException.StackTrace);
            }
        }

        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine($"Exceção com numero={numero} e divisor={divisor}");
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
