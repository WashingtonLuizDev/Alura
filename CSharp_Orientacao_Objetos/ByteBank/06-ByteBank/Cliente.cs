using System;
using System.Collections.Generic;
using System.Text;

namespace _06_ByteBank
{
    public class Cliente
    {
        private string _nome { get; set; }
        private string _cpf { get; set; }
        private string _profissao { get; set; }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string Profissao
        {
            get { return _profissao; }
            set { _profissao = value; }
        }

    }
}
