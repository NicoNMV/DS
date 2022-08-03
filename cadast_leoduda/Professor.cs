using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadast_leoduda
{
    internal class Professor : Pessoa
    {

        private string titulacao;

        public Professor()
        {
            this.titulacao = null;
        }
        public Professor(string nome, int idade, string titulacao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Titulacao = titulacao;
        }

        public String Titulacao
        {
            get { return this.titulacao; }
            set { titulacao = value; }
        }

        public override string ImpremeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome," ", this.Idade.ToString(), " ", this.Titulacao);   
            return s;
        }

    }
}
