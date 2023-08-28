using System;
using System.Drawing;

internal class Program
{
    public interface IData
{
    public void setData(DateTime data);
    public DateTime getData();
    public string dataString();
}

public class Produto : IData
{
    public string? nome { get; set; }
    public double valor { get; set; }
    public DateTime DataDeValidade { get; set; }

    public void setData(DateTime data)
    {
        DataDeValidade = data;
    }
    public DateTime getData()
    {
        return DataDeValidade;
    }
    public string dataString()
    {
        return DataDeValidade.ToString();
    }

}

public class Venda : IData
{
    public DateTime Data { get; set; }
    public Produto produto { get; set; }

    public void setData(DateTime data)
    {
        Data = data;
    }
    public DateTime getData()
    {
        return Data;
    }
    public string dataString()
    {
        return Data.ToString();
    }

}

public static class TestarVenda
{
    public static string DetalhesVenda(Venda venda)
    {
        return $"Data da venda: {venda.Data.ToString("dd/MM/yyyy")} - Produto: {venda.produto.nome} - Valor do produto: {venda.produto.valor} - Vencimento: {venda.produto.DataDeValidade.ToString("dd/MM/yyyy")}";
    }
}

static void Main(string[] args)
    {

        Produto produto = new Produto();
        produto.nome = "Leite Integral";
        produto.valor = 5;
        produto.setData(new DateTime(2023, 3, 1));
        Venda venda = new Venda();
        venda.produto = produto;
        venda.setData(DateTime.Now);
        TestarVenda.DetalhesVenda(venda);
        Console.WriteLine(TestarVenda.DetalhesVenda(venda));
    }
}

