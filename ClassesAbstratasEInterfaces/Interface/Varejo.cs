using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Varejo : Empresa, IEmpresa
    {
        //private readonly EnviarNotificacaoWhatsApp

        //public Varejo()
        //{

        //}

        public void ImprimirInformacoes()
        {
            StringBuilder empresa = new StringBuilder();

            empresa.AppendLine($"CNPJ do Varejo: {CNPJ}");
            empresa.AppendLine($"Nome do Varejo: {Nome}");

            Console.WriteLine(empresa.ToString());
        }

        public void RealizarVenda()
        {
            Console.WriteLine("Varejo vende produtos");
        }
    }
}
