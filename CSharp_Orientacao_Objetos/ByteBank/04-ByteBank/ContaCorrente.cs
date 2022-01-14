using System;
using System.Collections.Generic;
using System.Text;

namespace _04_ByteBank
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; } 
        public int Numero { get; set; }
        public double Saldo { get; set; } = 100;

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
