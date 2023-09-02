using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Empreiteira : Empresa, IEmpresa
    {
        public void ImprimirInformacoes()
        {
            StringBuilder empresa = new StringBuilder();

            empresa.AppendLine($"CNPJ da Empreiteira: {CNPJ}");
            empresa.AppendLine($"Nome da Empreiteira: {Nome}");

            Console.WriteLine(empresa.ToString());
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Empreiteira vende serviços");
        }
    }
}
