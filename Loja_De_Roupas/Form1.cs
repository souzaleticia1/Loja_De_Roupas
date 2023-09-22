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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                (@Nome, @Prontuario, @Telefone, @CPF, @Senha)";

            sqlCommand.Parameters.AddWithValue("@Nome", txbName.Text);
            sqlCommand.Parameters.AddWithValue("@Prontuario", txbPront.Text);
            sqlCommand.Parameters.AddWithValue("@Telefone", mtxbPhone.Text);
            sqlCommand.Parameters.AddWithValue("@CPF", mtxbCPF.Text);
            sqlCommand.Parameters.AddWithValue("@Senha", txbPass.Text);

            sqlCommand.ExecuteNonQuery();
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
