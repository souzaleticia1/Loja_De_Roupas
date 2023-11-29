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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hashPassL = Senha.Sha256(txbPassL.Text);
            Usuario user = new Usuario(
                                        Convert.ToDecimal(mtxbCpfL.Text.Replace(".", "").Replace("-", "")),
                                        hashPassL);
            //criar objeto da classe UsuarioDAO
            //chamar o método que verifica se o usuario e a senha existem na tabela
            UsuarioDAO dadosUser = new UsuarioDAO();
            if (dadosUser.Login(user))
            {
                //instanciando objetos da classe Form1 (esses são os comandos para abrir outra tela)
                Form2 form2 = new Form2();
                //ShowDialog bloqueia tudo que está atras dela, já o Show não bloqueia, então da para clicar na tela de login, por isso estamos usando o ShowDialog
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuário inválido");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //instanciando objetos da classe Form1 (esses são os comandos para abrir outra tela)
            Form1 form1 = new Form1();
            //ShowDialog bloqueia tudo que está atras dela, já o Show não bloqueia, então da para clicar na tela de login, por isso estamos usando o ShowDialog
            form1.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txbPassL_TextChanged(object sender, EventArgs e)
        {
            txbPassL.Text = new string('*', txbPassL.Text.Length);
        }
    }
}
