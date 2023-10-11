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
        //internal é mais restrito que public. Existem internal, public (acessível a qualquer outro [projeto] de código/dá para acessar por meio de outras classes) e private (acessível somente dentro daquela classe)
        //(-adendo no (3)-) diferença de atributo, propriedade começa com maiúsculo
        //é pelo construtor que vc cmç a execussão da classe. Todo método precisa de um construtor por isso
        //estão encapisulados(?)
        //pricisa retornar os valores, por isso criamos as propriedades
        //propriedade não tem (), método sempre vai ter

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

            //(2.3)
            //set: setar(atribuir) um valor para a variável que está lá em cima (validação); sempre que atribui um valor passa pelo set; o set é para fazer atribuição do valor
            //get: retorna á um atributo que está lá em cima (simplesmente retorna)

        //(3)
            //(3.1)
            //validar os dados que o usuário está usando nessa classe
            // os com _ são atributos e o Nome que começa com maiúsculo é uma propriedade, por isso está desse jeito. (por isso que o public string Nome é maiúsculo)
            //throw new é um lançamento de excessão para que a gente resolva o problema; lança a excessão para quem chamou a (classe) pq ela consegue lidar com isso (dizer que está errado)

            //(3.2)
            //quando lança uma exeção, precisa do try catch; tem que colocar o try catch onde possivelmente pode ter erro

        //(1)
        private int  _id;
        private string  _nome;
        private string  _prontuario;
        private string  _telefone;
        private string  _cpf;
        private string  _senha;


        //(2)
        public Usuario(string nome,
                       string prontuario,
                       string telefone,
                       string cpf,
                       string senha){

           Nome = nome;
            Prontuario = prontuario;
            Telefone = telefone;
            Cpf = cpf;
            Senha = senha;
        }

        //(2.1)
        public Usuario(int id,
                       string nome,
                       string prontuario,
                       string telefone,
                       string cpf,
                       string senha)
        {
            Id = id;
            Nome = nome;
            Prontuario = prontuario;
            Telefone = telefone;
            Cpf = cpf;
            Senha = senha;
        }

        //(3)
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

            public string Nome
        {
             set { 
                if(string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Nome está vazio!");
                _nome = value;

            }
            get { return _nome; }
        }

        public string Prontuario
        {
             set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Prontuário está vazio!");
                _prontuario = value;
            
            }
            get { return _prontuario; }
        }

        public string Telefone
        {
             set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Telefone está vazio!");
                _telefone = value;
            
            }
            get { return _telefone; }
        }

        public string Cpf
        {
             set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo CPF está vazio!");
                _cpf = value;
            
            }
            get { return _cpf; }
        }

        public string Senha
        {
             set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Senha está vazio!");
                _senha = value;
            
            }
            get { return _senha; }
        }
    }
}
