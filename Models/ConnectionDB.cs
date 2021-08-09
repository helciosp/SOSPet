using MySqlConnector;
using System.IO;

namespace SOSPet.Models
{
    public class ConnectionDB
    {

        protected static string _strConexao = File.ReadAllText(@"C:\Users\helci\config\Config.txt");
        protected MySqlConnection connection = new MySqlConnection(_strConexao);
        
    }
}