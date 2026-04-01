using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Aula_POO
{
    internal class jogadorFutsal : Jogador
    {
        public String nome;
        public int idade;
        public int gols;
        public double peso;
        public double altura;
        public String time;
        public String posicao;
        protected override void CadastrarJogador()
        {
            Console.Clear();
            Console.WriteLine("INSIRA O NOME DO JOGADOR: ");
            nome = Console.ReadLine();
            Console.WriteLine("INSIRA A IDADE DO JOGADOR: ");
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("INSIRA A QUANTIDADE DE GOLS DO JOGADOR: ");
            gols = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("INSIRA O PESO DO JOGADOR: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INSIRA A ALTURA DO JOGADOR: ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("INSIRA O TIME DO JOGADOR: ");
            time = Console.ReadLine();
            Console.WriteLine("INSIRA A POSIÇÃO DO JOGADOR: ");
            posicao = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("O jogador " + nome + "possui" + idade + " anos e marcou " + gols + " jogando na posição de " + posicao + " pelo time " + time + ".");
            Console.WriteLine("DADOS TÉCNICOS:");
            Console.WriteLine("NOME:" + nome);
            Console.WriteLine("IDADE:" + idade);
            Console.WriteLine("PESO:" + peso);
            Console.WriteLine("ALTURA:" + altura);
        }
        public void chamarCadastro()
        {
            CadastrarJogador();
        }
    }
}
