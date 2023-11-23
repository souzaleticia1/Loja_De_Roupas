using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_De_Roupas
{
    public class Endereco
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
        private int _id;
        private decimal _cep;
        private string _estado;
        private string _cidade;
        private string _bairro;
        private string _rua;
        private decimal _numero;


        //(2)
        public Endereco(
                        decimal cep,
                        string estado,
                        string cidade,
                        string bairro,
                        string rua,
                        decimal numero)
        {
            Cep = cep;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
        }

        //(2)
        public Endereco(
                       int id,
                       decimal cep,
                       string estado,
                       string cidade,
                       string bairro,
                       string rua,
                       decimal numero)
        {
            Id = id;
            Cep = cep;
            Estado = estado;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
        }
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }

        public decimal Cep
        {
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new ArgumentNullException("Campo Nome está vazio!");
                _cep = value;

            }
            get { return _cep; }
        }
        public string Estado
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Nome está vazio!");
                _estado = value;

            }
            get { return _estado; }
        }
        public string Cidade
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Nome está vazio!");
                _cidade = value;

            }
            get { return _cidade; }
        }
        public string Bairro
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Nome está vazio!");
                _bairro = value;

            }
            get { return _bairro; }
        }
        public string Rua
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Campo Nome está vazio!");
                _rua = value;

            }
            get { return _rua; }
        }
        public decimal Numero
        {
            set
            {
                if (string.IsNullOrEmpty(value.ToString()))
                    throw new ArgumentNullException("Campo Nome está vazio!");
                _numero = value;

            }
            get { return _numero; }
        }
    }
}
