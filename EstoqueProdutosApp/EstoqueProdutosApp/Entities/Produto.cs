namespace EstoqueProdutosApp.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get; set; }

        public Produto()
        {
        }

        public Produto(string nome, double preco, int quantidade, double valorTotal)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
        }

        public double ValorTotalEmEstoque()
        {
            ValorTotal = Quantidade * Preco;
            return ValorTotal;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
