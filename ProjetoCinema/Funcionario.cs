using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema
{
    public class Funcionario
    {
        private string nome;
        private string senha;
        private string turno;

        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Turno { get => turno; set => turno = value; }

        public string MostraFunc()
        {
            return "Nome: " + Nome + " \tTurno: " + Turno;
        }
    }
}
