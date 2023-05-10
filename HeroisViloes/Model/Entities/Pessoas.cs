using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroisViloes.Model.Entities
{
     public class Pessoas
    {      
        private int idPessoa;
        private string nomePessoa;
        private int anoNascimento;
        private int idade;
        private string email;

        //---- Construtor ----//
        public Pessoas()
        {
            idPessoa = 0;
            nomePessoa = null;
            anoNascimento = 0;
            idade = 0;
            email = null;
        }

        //---- Propriedades ----//
        public int IdPessoa
        {
            get { return idPessoa; }
            set { idPessoa = value; }
        }

        public string NomePessoa
        {
            get { return nomePessoa; }
            set { nomePessoa = value; }
        }

        public int AnoNasc
        {
            get { return anoNascimento; }
            set { anoNascimento = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //---- Método Abstrato ----//
       // public abstract void calcularIdade(int anoAtual);
    }
}

