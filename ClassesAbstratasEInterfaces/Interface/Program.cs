

using Interface;

List<IEmpresa> empresas = new();

IEmpresa varejo = new Varejo()
{
    CNPJ = "00.776.574/0001-56",
    Nome = "Americanas"
};

IEmpresa empreiteira = new Empreiteira()
{
    CNPJ = "71.476.527/0001-35",
    Nome = "Tenda"
};

empresas.Add(varejo);
empresas.Add(empreiteira);

foreach (var empresa in empresas)
{
    empresa.ImprimirInformacoes();
    empresa.RealizarVenda();

}