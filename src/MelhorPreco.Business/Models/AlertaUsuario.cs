namespace MelhorPreco.Business.Models
{
    public class AlertaUsuario : Entity
    {
        public Guid UsuarioId { get; set; } // Chave estrangeira para o usuário
        public Guid ProdutoId { get; set; } // Chave estrangeira para o produto
        public decimal PrecoAlvo { get; set; } // Preço desejado para disparar o alerta
        public DateTime DataCadastro { get; set; } // Data de criação do alerta

        // Navegação para o usuário e produto relacionados
        public Usuario Usuario { get; set; }
        public Produto Produto { get; set; }
    }
}
