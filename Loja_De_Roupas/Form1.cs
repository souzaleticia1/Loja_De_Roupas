using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Loja_De_Roupas
{
    public partial class Form1 : Form
    {
        private int id;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListView()
        {
            ListView1.Items.Clear();
            UsuarioDAO usuarioDAO = new UsuarioDAO();
            List<Usuario> users = usuarioDAO.SelectUser();

            try
            {
                //foreach vai percorrer cada linha de usuario
                foreach (Usuario usuario in users)
                {
                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(usuario.Nome);
                    lv.SubItems.Add(usuario.Prontuario);
                    lv.SubItems.Add(usuario.Telefone.ToString());
                    lv.SubItems.Add(usuario.Cpf.ToString());
                    lv.SubItems.Add(usuario.Senha);
                    ListView1.Items.Add(lv);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void lbl6_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {

            //ver classe usuario //(3.2)
            try
            {
                //criar um objeto da classe Usuario
                //esse Usuario verde água é o nome da sua classe
                Usuario user = new Usuario(
                                        txbName.Text,
                                        txbPront.Text,
                                        Convert.ToDecimal(mtxbPhone.Text),
                                        Convert.ToDecimal(mtxbCPF.Text),
                                        txbPass.Text);

                //chamando o método de inserção  ---->  //cria o objeto e chama o método específico
                UsuarioDAO usuarioDAO = new UsuarioDAO();     //UsuarioDAO nomeDoObj = new UsuarioDAO();
                usuarioDAO.InsertUser(user);

                MessageBox.Show("Salvo com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }

            

            txbName.Clear();
            txbPront.Clear();
            mtxbPhone.Clear();
            mtxbCPF.Clear();
            txbPass.Clear();

            UpdateListView();
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = ListView1.FocusedItem.Index;
            id = int.Parse(ListView1.Items[index].SubItems[0].Text);
            txbName.Text = ListView1.Items[index].SubItems[1].Text;
            txbPront.Text = ListView1.Items[index].SubItems[2].Text;
            mtxbPhone.Text = ListView1.Items[index].SubItems[3].Text;
            mtxbCPF.Text = ListView1.Items[index].SubItems[4].Text;
            txbPass.Text = ListView1.Items[index].SubItems[5].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ver classe usuario //(3.2)
            try
            {
                //criar um objeto da classe Usuario
                //esse Usuario verde água é o nome da sua classe
                Usuario user = new Usuario(
                                        id,
                                        txbName.Text,
                                        txbPront.Text,
                                        Convert.ToDecimal(mtxbPhone.Text),
                                        Convert.ToDecimal(mtxbCPF.Text),
                                        txbPass.Text);

                //chamando o método de inserção  ---->  //cria o objeto e chama o método específico
                UsuarioDAO usuarioDAO = new UsuarioDAO();     //UsuarioDAO nomeDoObj = new UsuarioDAO();
                usuarioDAO.UpdateUser(user);

                MessageBox.Show("Atualizado com sucesso",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

            txbName.Clear();
            txbPront.Clear();
            mtxbPhone.Clear();
            mtxbCPF.Clear();
            txbPass.Clear();

            UpdateListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //chamando o método de exclusão  ---->  //cria o objeto e chama o método específico
            UsuarioDAO usuarioDAO = new UsuarioDAO();     //UsuarioDAO nomeDoObj = new UsuarioDAO();
            usuarioDAO.DeleteUser(id);

            MessageBox.Show("Excluído com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //limpando campos
            txbName.Clear();
            txbPront.Clear();
            mtxbPhone.Clear();
            mtxbCPF.Clear();
            txbPass.Clear();

            //atualizando ListView
            UpdateListView();
        }


































        //{

        //    if (validarForm())
        //        Salvar();
        //}

        //    private void Salvar()
        //    {
        //        MessageBox.Show("Os dados foram salvos!");
        //    }

        //    private bool validarForm()
        //    {
        //        if (txbName.Text == "")
        //        {
        //            MessageBox.Show("Informe o Nome");
        //            txbName.Focus();
        //            return false;
        //        }
        //    else if (txbPront.Text == "")
        //    {
        //        MessageBox.Show("Informe o Prontuário");
        //        txbPront.Focus();
        //        return false;
        //    }
        //    else if (mtxbPhone.Text == "")
        //    {
        //        MessageBox.Show("Informe o Telefone");
        //        mtxbPhone.Focus();
        //        return false;
        //    }
        //    else if (mtxbCPF.Text == "")
        //    {
        //        MessageBox.Show("Informe o CPF");
        //        mtxbCPF.Focus();
        //        return false;
        //    }
        //    else if (txbPass.Text == "")
        //    {
        //        MessageBox.Show("Informe a Senha");
        //        txbPass.Focus();
        //        return false;
        //    }
        //    return true;
        //}

















        //string name = txbName.Text;
        //string enrollment = txbPront.Text;

        //string message = "Nome: " + name +
        //                 "\nMatrícula: " + enrollment;

        //MessageBox.Show(
        //    message,
        //        "ATENÇÃO",
        //        MessageBoxButtons.OK,
        //        MessageBoxIcon.Information
        //       );
        //}
    }
}
