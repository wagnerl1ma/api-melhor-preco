namespace MelhorPreco.Business.Models
{
    public class Usuario : Entity
    {
        public string Nome { get; set; } // Nome do usuário
        public string Email { get; set; } // E-mail do usuário
        public string PasswordHash { get; set; } // Hash da senha para autenticação
        public bool Ativo { get; set; } = true; // Indica se o usuário está ativo

        // Relacionamento com alertas cadastrados pelo usuário
        public ICollection<AlertaUsuario> Alertas { get; set; }
    }
}
