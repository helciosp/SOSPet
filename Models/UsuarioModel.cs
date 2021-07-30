using System;

namespace SOSPet.Models
{
    public class UsuarioModel
    {
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
    }
}