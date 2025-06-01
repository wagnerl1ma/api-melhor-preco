namespace MelhorPreco.Business.Models
{
    public class LogNotificacao : Entity
    {
        public Guid UsuarioId { get; set; } // Usuário que recebeu a notificação
        public Guid ProdutoId { get; set; } // Produto relacionado à notificação
        public decimal PrecoNotificado { get; set; } // Preço do produto no momento da notificação
        public DateTime DataNotificacao { get; set; } // Data/hora em que a notificação foi enviada

        // Navegação para usuário e produto
        public Usuario Usuario { get; set; }
        public Produto Produto { get; set; }
    }
}
