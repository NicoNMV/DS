using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadast_leoduda
{
    internal class Aluno : Pessoa
    {
        private string curso;

        public Aluno()
        {
            this.curso = null;
        }
        public Aluno(string nome, int idade, string curso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Curso = curso;
        }

        public String Curso
        {
            get { return this.curso; }
            set { curso = value; }
        }

        public override string ImpremeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, " ", this.Idade.ToString(), " ", this.Curso);
            return s;
        }
    }
}
