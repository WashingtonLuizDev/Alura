using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; set; }
        public double ValorSaque { get; set; }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque) 
            : this($"Tentativa de saque de {valorSaque} com saldo de {saldo}")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna)
            : base(mensagem, excecaoInterna)
        {

        }


    }
}
