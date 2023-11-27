using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_De_Roupas
{
        //DAO = Data Acess Object
        //essa é a classe que vai ligar com o BD
    internal class EnderecoDAO
    {
        //quando um método não tem retorno ele é do tipo void. Ele não precisa retornar nada, ele só vai executar a ação e acabou.

        //() do método é chamado de parâmetro. quando tem que declarar algo, é nele que faz

        //bool --> booleano (só da true e false)

        public List<Endereco> SelectAddress()
        {
            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM Endereco";

            List<Endereco> adresses = new List<Endereco>();
            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (dr.Read())
                {
                    Endereco objeto = new Endereco(
                        (int)dr["ID"],
                        (decimal)dr["CEP"],
                        (string)dr["Estado"],
                        (string)dr["Cidade"],
                        (string)dr["Bairro"],
                        (string)dr["Rua"],
                        (decimal)dr["Numero"]
                    );

                    adresses.Add(objeto);
                }
                dr.Close();
                return adresses;//retornar a lista
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

        public void InsertAddress(Endereco address)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO Endereco VALUES
                (@CEP, @Estado, @Cidade, @Bairro, @Rua, @Numero)"
            ;


            sqlCommand.Parameters.AddWithValue("@CEP", address.Cep);
            sqlCommand.Parameters.AddWithValue("@Estado", address.Estado);
            sqlCommand.Parameters.AddWithValue("@Cidade", address.Cidade);
            sqlCommand.Parameters.AddWithValue("@Bairro", address.Bairro);
            sqlCommand.Parameters.AddWithValue("@Rua", address.Rua);
            sqlCommand.Parameters.AddWithValue("@Numero", address.Numero);

            sqlCommand.ExecuteNonQuery();
        }
        public void DeleteAddress(int id)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM Endereco WHERE ID = @id";
            sqlCommand.Parameters.AddWithValue("@id", id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir endereço no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();
            }
        }
        public void UpdateAddress(Endereco address)
        {
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE Endereco SET 
            CEP       = @CEP, 
            Estado = @Estado,
            Cidade        = @Cidade, 
            Bairro  = @Bairro,  
            Rua   = @Rua
            Numero   = @Numero
            WHERE ID   = @id";

            //idêntico ao do botão insert
            sqlCommand.Parameters.AddWithValue("@ID", address.Id);
            sqlCommand.Parameters.AddWithValue("@Nome", address.Cep);
            sqlCommand.Parameters.AddWithValue("@Prontuario", address.Estado);
            sqlCommand.Parameters.AddWithValue("@Telefone", address.Cidade);
            sqlCommand.Parameters.AddWithValue("@CPF", address.Bairro);
            sqlCommand.Parameters.AddWithValue("@senha", address.Rua);
            sqlCommand.Parameters.AddWithValue("@senha", address.Numero);

            sqlCommand.ExecuteNonQuery();
        }
    }
}
