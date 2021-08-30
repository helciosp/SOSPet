using MySqlConnector;

namespace SOSPet.Models
{
    public class EnderecoRepository : ConnectionDB
    {
        public void Insert(EnderecoModel newEndereco, int IdUsuario)
        {
            connection.Open();
            string sql = 
            "INSERT INTO tb_endereco (cep, estado, cidade, bairro, rua, numero, id_usuario) VALUES (@Cep, @Estado, @Cidade, @Bairro, @Rua, @Numero, @IdUsuario)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Cep", newEndereco.Cep);
            command.Parameters.AddWithValue("@Estado", newEndereco.Estado);
            command.Parameters.AddWithValue("@Cidade", newEndereco.Cidade);
            command.Parameters.AddWithValue("@Bairro", newEndereco.Bairro);
            command.Parameters.AddWithValue("@Rua", newEndereco.Rua);
            command.Parameters.AddWithValue("@Numero", newEndereco.Numero);
            command.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            command.ExecuteNonQuery();  
            connection.Close();
        }
    }
}