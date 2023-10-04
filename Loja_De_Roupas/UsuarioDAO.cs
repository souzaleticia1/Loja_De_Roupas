using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_De_Roupas
{
    //DAO = Data Acess Object
    //essa é a classe que vai ligar com o BD
    internal class UsuarioDAO
    {
        //quando um método não tem retorno ele é do tipo void. Ele não precisa retornar nada, ele só vai executar a ação e acabou.

        //() do método é chamado de parâmetro. quando tem que declarar algo, é nele que faz
        public void DeleteUser(int id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Usuario WHERE Id = @id";
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
    }
}
