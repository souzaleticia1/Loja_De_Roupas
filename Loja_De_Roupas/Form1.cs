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

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Usuario";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    int id = (int)dr["ID"];
                    string name = (string)dr["Nome"];
                    string job = (string)dr["Prontuario"];
                    decimal tel = (decimal)dr["Telefone"];
                    decimal cpf = (decimal)dr["CPF"];
                    string pass = (string)dr["senha"];

                    ListViewItem lv = new ListViewItem(id.ToString());
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(job);
                    lv.SubItems.Add(tel.ToString());
                    lv.SubItems.Add(cpf.ToString());
                    lv.SubItems.Add(pass);
                    ListView1.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
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

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Usuario VALUES
                (@Nome, @Prontuario, @Telefone, @CPF, @senha)";

            sqlCommand.Parameters.AddWithValue("@Nome", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@Prontuario", txbPront.Text);
            sqlCommand.Parameters.AddWithValue("@Telefone", mtxbPhone.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", mtxbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbPass.Text);

            sqlCommand.ExecuteNonQuery();
            txbName.Clear();
            txbPront.Clear();
            mtxbPhone.Clear();
            mtxbCPF.Clear();
            txbPass.Clear();
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
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Usuario SET 
    Nome       = @Nome, 
    Prontuario = @Prontuario,
    CPF        = @CPF, 
    Telefone  = @Telefone, 
    senha   = @Senha
    WHERE ID   = @id";

            sqlCommand.Parameters.AddWithValue("@Nome", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@Prontuario", txbPront.Text);
            sqlCommand.Parameters.AddWithValue("@Telefone", mtxbPhone.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", mtxbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@senha", txbPass.Text);
            sqlCommand.Parameters.AddWithValue("@id", id);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Atualizado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txbName.Clear();
            txbPront.Clear();
            mtxbPhone.Clear();
            mtxbCPF.Clear();
            txbPass.Clear();

            UpdateListView();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Usuarios WHERE Id = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
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
