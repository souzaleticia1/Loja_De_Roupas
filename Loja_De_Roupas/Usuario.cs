using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_De_Roupas
{
    public class Usuario
    {
        //(1)
        //internal é mais restrito que public. Existem internal, public (acessível a qualquer outro [projeto] de código) e private (acessível somente dentro daquela classe)
        //(-adendo no (3)-) diferença de atributo, propriedade começa com maiúsculo
        //é pelo construtor que vc cmç a execussão da classe. Todo método precisa de um construtor por isso

        //(2)
            //(2.1)
            //Esse é o método construtor

            //(2.2)
            //public Usuario(string nome,
            //string prontuario,
            //           decimal telefone,
            //           decimal cpf,
            //           string Senha){

            //    Nome = nome;
            //    Prontuario = prontuario;
            //    Telefone = telefone;
            //    CPF = cpf;
            //    this.Senha = Senha;      ------>       se o nome dentro do parenteses for igual ao nome do private string, tem que colocar o this. no lado do do private string
            //}

        //(3)
        //validar os dados que o usuário está usando nessa classe
        // os com _ são atributos e o Nome que começa com maiúsculo é uma propriedade, por isso está desse jeito. (por isso que o public string Nome é maiúsculo)

        //(1)
        private string  _id;
        private string  _nome;
        private string  _prontuario;
        private decimal  _telefone;
        private decimal  _cpf;
        private string  _senha;


        //(2)
        public Usuario(string nome,
                       string prontuario,
                       decimal telefone,
                       decimal cpf,
                       string senha){

            _nome = nome;
            _prontuario = prontuario;
            _telefone = telefone;
            _cpf = cpf;
            _senha = senha;
        }

        //(3)
        public string Id
        {
            set { _id = value; }
            get { return _id; }
        }

            public string Nome
        {
             set { _nome = value; }
            get { return _nome; }
        }

        public string Prontuario
        {
             set { _prontuario = value; }
            get { return _prontuario; }
        }

        public decimal Telefone
        {
             set { _telefone = value; }
            get { return _telefone; }
        }

        public decimal Cpf
        {
             set { _cpf = value; }
            get { return _cpf; }
        }

        public string Senha
        {
             set { _senha = value; }
            get { return _senha; }
        }
    }
}
