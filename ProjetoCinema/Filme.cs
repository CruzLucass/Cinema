using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    public class Filme
    {
        private string nomefilme;
        private string duracao;
        private int classificacao;
        private string genero;
        public string Nomefilme { get => nomefilme; set => nomefilme = value; }
        public string Duracao { get => duracao; set => duracao = value; }
        public int Classificacao { get => classificacao; set => classificacao = value; }
        public string Genero { get => genero; set => genero = value; }

        public string MostraFilme()
        {
            return "Titulo: " + Nomefilme + "\t Genero: " + Genero + "\tClassificação: " + Classificacao + " anos" + "\tDuração: " + Duracao;
        }
    }
}
