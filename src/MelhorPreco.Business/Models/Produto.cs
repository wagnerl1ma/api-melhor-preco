namespace MelhorPreco.Business.Models
{
    public class Produto : Entity
    {
        public string Nome { get; set; } // Nome do produto monitorado
        public string Url { get; set; } // URL da página do produto a ser monitorada
        public string? CodigoProduto { get; set; } // Código do produto para identificação e controle (ex: SKU)
        public DateTime DataCadastro { get; set; } // Data e hora do cadastro do produto no sistema
        public bool Ativo { get; set; } = true; // Indica se o produto está ativo para monitoramento

        // Relacionamento com histórico de preços
        public List<HistoricoPreco> HistoricosPrecos { get; set; }
    }
}
