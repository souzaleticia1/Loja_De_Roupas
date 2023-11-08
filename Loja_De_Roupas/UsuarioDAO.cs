using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Loja_De_Roupas
{
    //DAO = Data Acess Object
    //essa é a classe que vai ligar com o BD
    internal class UsuarioDAO
    {
        //quando um método não tem retorno ele é do tipo void. Ele não precisa retornar nada, ele só vai executar a ação e acabou.

        //() do método é chamado de parâmetro. quando tem que declarar algo, é nele que faz

        //bool --> booleano (só da true e false)
        public bool Login(Usuario user)
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Usuario where Nome = @Nome and senha = @senha";

            sqlCom.Parameters.AddWithValue("@Nome", user.Nome);
            sqlCom.Parameters.AddWithValue("@senha", user.Senha);

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Close();
                    return true;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return false;
        }
            public List<Usuario> SelectUser()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Usuario";

            List<Usuario> users = new List<Usuario>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Usuario objeto = new Usuario(
                        (int)dr["ID"],
                        (string)dr["Nome"],
                        (string)dr["Prontuario"],
                        (decimal)dr["Telefone"],
                        (decimal)dr["CPF"],
                        (string)dr["senha"]
                    );

                    users.Add(objeto);
                }
                dr.Close();
                return users;//retornar a lista
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
            return null;
        }
        public void InsertUser(Usuario user)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Usuario VALUES
                (@Nome, @Prontuario, @Telefone, @CPF, @senha)"
            ;

            
            sqlCommand.Parameters.AddWithValue("@Nome", user.Nome);
            sqlCommand.Parameters.AddWithValue("@Prontuario", user.Prontuario);
            sqlCommand.Parameters.AddWithValue("@Telefone", user.Telefone);
            sqlCommand.Parameters.AddWithValue("@CPF", user.Cpf);
            sqlCommand.Parameters.AddWithValue("@senha", user.Senha);

            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteUser(int id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Usuario WHERE ID = @id";
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
        public void UpdateUser(Usuario user)
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

            //idêntico ao do botão insert
            sqlCommand.Parameters.AddWithValue("@ID", user.Id);
            sqlCommand.Parameters.AddWithValue("@Nome", user.Nome);
            sqlCommand.Parameters.AddWithValue("@Prontuario", user.Prontuario);
            sqlCommand.Parameters.AddWithValue("@Telefone", user.Telefone);
            sqlCommand.Parameters.AddWithValue("@CPF", user.Cpf);
            sqlCommand.Parameters.AddWithValue("@senha", user.Senha);

            sqlCommand.ExecuteNonQuery();
        }

    }
}
