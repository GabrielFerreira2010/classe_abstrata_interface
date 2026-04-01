using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_POO
{
    internal class JogadorBasquete : Jogador
    {
        public String nome;
        public int idade;
        public double altura;
        public int doispontos;
        public int trespontos;
        public int pontos;
        protected override void CadastrarJogador()
        {
            Console.Clear();
            Console.WriteLine("INSIRA O NOME DO JOGADOR: ");
            nome = Console.ReadLine();
            Console.WriteLine("INSIRA A IDADE DO JOGADOR: ");
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("INSIRA A ALTURA DO JOGADOR: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INSIRA A QUANTIDADE DE CESTAS DE DOIS PONTOS FEITAS PELO JOGADOR: ");
            doispontos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("INSIRA A QUANTIDADES DE CESTAS DE TRÊS PONTOS FEITAS PELO JOGADOR: ");
            trespontos = Convert.ToInt16(Console.ReadLine());
            calcularPontos();
        }
        public void calcularPontos ()
        {
            pontos = (doispontos * 2) + (trespontos * 3);
            Console.WriteLine("Total de pontos: " + pontos);
           
        }
    }
}