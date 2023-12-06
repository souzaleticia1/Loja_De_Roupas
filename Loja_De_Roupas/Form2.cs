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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loja_De_Roupas
{
    public partial class Form2 : Form
    {
        private int id;
        public Form2()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            listView1.Items.Clear();
            EnderecoDAO enderecoDAO = new EnderecoDAO();
            List<Endereco> adresses = enderecoDAO.SelectAddress(); 

            try
            {
                if (adresses != null && adresses.Count > 0)
                { //foreach vai percorrer cada linha de usuario
                    foreach (Endereco endereco in adresses)
                    {
                        ListViewItem lv = new ListViewItem(endereco.Id.ToString());
                        lv.SubItems.Add(endereco.Cep.ToString());
                        lv.SubItems.Add(endereco.Estado);
                        lv.SubItems.Add(endereco.Cidade);
                        lv.SubItems.Add(endereco.Bairro);
                        lv.SubItems.Add(endereco.Rua);
                        lv.SubItems.Add(endereco.Numero.ToString());
                        listView1.Items.Add(lv);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
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

            //atualizando ListView
            UpdateListView();
        }
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index;
            index = listView1.FocusedItem.Index;
            id = int.Parse(listView1.Items[index].SubItems[0].Text);
            mtxbCEP.Text = listView1.Items[index].SubItems[1].Text;
            txbEstado.Text = listView1.Items[index].SubItems[2].Text;
            txbCidade.Text = listView1.Items[index].SubItems[3].Text;
            txbBairro.Text = listView1.Items[index].SubItems[4].Text;
            txbRua.Text = listView1.Items[index].SubItems[5].Text;
            txbNumero.Text = listView1.Items[index].SubItems[6].Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {


            //ver classe usuario //(3.2)
            try
            {
                //criar um objeto da classe Usuario
                //esse Usuario verde água é o nome da sua classe
                Endereco address = new Endereco(
                                        id,
                                        Convert.ToDecimal(mtxbCEP.Text),
                                        txbEstado.Text,
                                        txbCidade.Text,
                                        txbBairro.Text,
                                        txbRua.Text,
                                        Convert.ToDecimal(txbNumero.Text));

                //chamando o método de inserção  ---->  //cria o objeto e chama o método específico
                EnderecoDAO enderecoDAO = new EnderecoDAO();     //UsuarioDAO nomeDoObj = new UsuarioDAO();
                enderecoDAO.UpdateAddress(address);

                MessageBox.Show("Atualizado com sucesso",
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

            //atualizando ListView
            UpdateListView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //chamando o método de exclusão  ---->  //cria o objeto e chama o método específico
            EnderecoDAO enderecoDAO = new EnderecoDAO();     //UsuarioDAO nomeDoObj = new UsuarioDAO();
            enderecoDAO.DeleteAddress(id);

            MessageBox.Show("Excluído com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //limpando campos
            mtxbCEP.Clear();
            txbEstado.Clear();
            txbCidade.Clear();
            txbBairro.Clear();
            txbRua.Clear();
            txbNumero.Clear();

            //atualizando ListView
            UpdateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
