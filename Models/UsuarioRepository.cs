using MySqlConnector;

namespace SOSPet.Models
{
    public class UsuarioRepository : ConnectionDB
    {
        public void Insert(UsuarioModel newUsuario)
        {
            connection.Open();
            string sql = "INSERT INTO tb_usuario (primeiro_nome, segundo_nome, senha, telefone, data_nascimento, email, cpf) VALUES (@PrimeiroNome, @SegundoNome, @Senha, @Telefone, @DataNascimento, @Email, @Cpf)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@PrimeiroNome", newUsuario.PrimeiroNome);
            command.Parameters.AddWithValue("@SegundoNome", newUsuario.SegundoNome);
            command.Parameters.AddWithValue("@Senha", newUsuario.Senha);
            command.Parameters.AddWithValue("@Telefone", newUsuario.Telefone);
            command.Parameters.AddWithValue("@DataNascimento", newUsuario.DataNascimento);
            command.Parameters.AddWithValue("@Email", newUsuario.Email);
            command.Parameters.AddWithValue("@Cpf", newUsuario.Cpf);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}