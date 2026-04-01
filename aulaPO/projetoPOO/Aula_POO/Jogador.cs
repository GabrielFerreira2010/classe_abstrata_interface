using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_POO
{
    internal abstract class Jogador
    {
        public String nomejogador;
        public int idade;
        public double altura;
        public double peso;
        protected abstract void CadastrarJogador();
    }
}
