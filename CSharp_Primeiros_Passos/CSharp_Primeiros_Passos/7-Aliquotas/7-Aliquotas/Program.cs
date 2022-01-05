using System;

namespace _7_Aliquotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Calculando Alíquotas de Imposto de Renda");

            double salario = 3300.00;
            double aliquota = 0;
            double deducao = 0;

            if (salario >= 1900 && salario <= 2800) {
                aliquota = 7.5;
                deducao = salario * (aliquota / 100);
                if (deducao > 142) {
                    deducao = 142;
                }
            } else if (salario >= 2800.01 && salario <= 3751) {
                aliquota = 15;
                deducao = salario * (aliquota / 100);
                if (deducao > 350)
                {
                    deducao = 350;
                }
            } else if(salario >= 3751.01 && salario <= 4664)
            {
                aliquota = 22.5;
                deducao = salario * (aliquota / 100);
                if (deducao > 636)
                {
                    deducao = 636;
                }
            }

            if (aliquota > 0)
            {
                Console.WriteLine($"O valor do imposto que será deduzido é de R$ {deducao}. Está atendendo a aliquota de {aliquota}%.");
            }
            else {
                Console.WriteLine($"Como o valor da alíquota é {aliquota}%, não será deduzido nenhum valor do salário de R${salario}.");
            }

            Console.WriteLine("Aperte qualquer tecla para finalizar.");
            Console.ReadLine();
            
        }
    }
}
