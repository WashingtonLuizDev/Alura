using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int Agencia { get; }

        public int Numero { get; }

        private double _saldo = 100 ;

        public double Saldo
        {
            get
            { 
                return _saldo;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException($"Não é possível criar uma nova conta com a agencia menor ou igual a 0" +
                    $"\nAgencia informada: {agencia}",nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException($"Não é possível criar uma nova conta com a número menor ou igual a 0."+
                    $"\nNúmero informado: {numero}", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;
            
            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {

            if (valor < 0)
            {
                throw new ArgumentException($"Valor de saque não pode ser negativo. {nameof(valor)}");
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Operação não realizada.");
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException($"Valor inválido para a transferência. {nameof(valor)}");
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            
            contaDestino.Depositar(valor);
        }
    }
}
