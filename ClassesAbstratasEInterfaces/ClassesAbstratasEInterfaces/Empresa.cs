
using System.Text;

namespace ClassesAbstratasEInterfaces
{
    public abstract class Empresa
    {
        public string CNPJ { get; set; }
        public string Nome { get; set; }

        public abstract void RealizarVenda();

        public void ImprimirInformacoes()
        {
            StringBuilder empresa = new StringBuilder();

            empresa.AppendLine($"CNPJ: {CNPJ}");
            empresa.AppendLine($"Nome: {Nome}");

            Console.WriteLine(empresa.ToString());
        }
    }
}
