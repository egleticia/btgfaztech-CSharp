using EstoqueProdutosApp.Entities;
using System.Globalization;

Produto produto = new Produto();

Console.WriteLine("Por favor, insira os dados do produto: ");
Console.WriteLine("Nome do Produto: ");
produto.Nome = Console.ReadLine();

Console.WriteLine("Preço do Produto: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Quantidade do Produto em estoque: ");
produto.Quantidade = int.Parse(Console.ReadLine());

produto.ValorTotalEmEstoque();

Console.WriteLine($"Produto: {produto.Nome}");
Console.WriteLine($"Preço: {produto.Preco}");
Console.WriteLine($"Quantidade: {produto.Quantidade}");
Console.WriteLine($"Valor Total em Estoque: R$ {produto.ValorTotal}");

Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine("Realizar entrada de estoque. Insira a quantidade de produtos: ");
int quantidadeEntrada = int.Parse(Console.ReadLine());

produto.AdicionarProdutos(quantidadeEntrada);
produto.ValorTotalEmEstoque();

Console.WriteLine("Estoque Atualizado: ");
Console.WriteLine($"Produto: {produto.Nome}");
Console.WriteLine($"Preço: {produto.Preco}");
Console.WriteLine($"Quantidade: {produto.Quantidade}");
Console.WriteLine($"Valor Total em Estoque: R$ {produto.ValorTotal}");

Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine("Realizar saída de estoque. Insira a quantidade de produtos: ");
int quantidadeSaida = int.Parse(Console.ReadLine());

produto.RemoverProdutos(quantidadeSaida);
produto.ValorTotalEmEstoque();

Console.WriteLine("Estoque Atualizado: ");
Console.WriteLine($"Produto: {produto.Nome}");
Console.WriteLine($"Preço: {produto.Preco}");
Console.WriteLine($"Quantidade: {produto.Quantidade}");
Console.WriteLine($"Valor Total em Estoque: R$ {produto.ValorTotal}");








