using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ByteBank
{
    public class ContaCorrente
    {
        public string Titular { get; set; }
        public int Agencia { get; set; } 
        public int Numero { get; set; }
        public double Saldo { get; set; } = 100;
    }
}
