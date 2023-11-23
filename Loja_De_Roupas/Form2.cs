using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Loja_De_Roupas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ver classe usuario //(3.2)
            try
            {
                //criar um objeto da classe Usuario
                //esse Usuario verde água é o nome da sua classe
                Endereco  address = new Endereco(
                                        Convert.ToDecimal(mtxbCEP.Text),
                                        txbEstado.Text,
                                        txbCidade.Text,
                                        txbBairro.Text,
                                        txbRua.Text,
                                        Convert.ToDecimal(txbNumero.Text));

                //chamando o método de inserção  ---->  //cria o objeto e chama o método específico
                EnderecoDAO enderecoDAO = new EnderecoDAO();     //UsuarioDAO nomeDoObj = new UsuarioDAO();
                enderecoDAO.InsertAddress(address);

                MessageBox.Show("Salvo com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }



            mtxbCEP.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbBairro.Clear();
            txbRua.Clear();
            txbNumero.Clear();
        }
    }
}
