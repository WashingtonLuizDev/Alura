using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    public class ContaCorrente
    {
        private Cliente _titular { get; set; }
        private int _agencia { get; set; }
        private int _numero { get; set; }
        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }

        public Cliente Titular 
        {
            get 
            {
                return this._titular;
            }
            set 
            {
                _titular = value;
            }
        }

        public int Agencia
        {
            get
            {
                return this._agencia;
            }
            set
            {
                _agencia = value;
            }
        }

        public int Numero
        {
            get
            {
                return this._numero;
            }
            set
            {
                _numero = value;
            }
        }

        public bool Sacar(double valor) 
        {
            if (!ValidarTransacao(valor))
            {
                return false;
            }

            this.Saldo -= valor;
            
            return true;
        }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (!ValidarTransacao(valor))
            {
                return false;
            }

            this.Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

        private bool ValidarTransacao(double valor) {
            if (this.Saldo < valor)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
