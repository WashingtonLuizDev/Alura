using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel usuario, string senha) 
        {

            bool usuarioAutenticado = usuario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem Vindo ao Sistema!");
            }
            else {
                Console.WriteLine("Senha Incorreta!");
            }

            return usuarioAutenticado;
        }
    }
}
