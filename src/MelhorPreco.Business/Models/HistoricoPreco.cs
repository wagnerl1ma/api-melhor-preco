namespace MelhorPreco.Business.Models
{
    public class HistoricoPreco : Entity
    {
        public Guid ProdutoId { get; set; } // Chave estrangeira referenciando o produto monitorado
        public decimal Preco { get; set; } // Preço capturado do produto na data de consulta
        public DateTime DataConsulta { get; set; } // Data e hora em que o preço foi coletado

        // Navegação para o produto
        public Produto Produto { get; set; }
    }
}
