
using System.Reflection.Metadata.Ecma335;

namespace Library.Entities
{
    public class Emprestimo
    {
        public Pessoa Pessoa { get; set; }
        public Livro Livro { get; set; }
        private TimeSpan DiasEmprestimo { get; set; } = TimeSpan.FromDays(14); // O padrão de empréstimo é de 14 dias corridos
        private TimeSpan DiasEmprestimoReal { get; set; }
        private DateTime DataEmprestimoInicio { get; set; }
        public DateTime DataEmprestimoFinal { get; set; }
        private bool GerouMulta { get; set; }
        public double ValorMulta { get; set; }


        public Emprestimo()
        {

        }

        public void RealizarEmprestimo(Pessoa pessoa, Livro livro)
        {
            Pessoa = pessoa;
            Livro = livro;
            DataEmprestimoInicio = DateTime.Now;

            Console.WriteLine($"O livro {livro.Nome} foi emprestado a {pessoa.Nome}");
            Console.WriteLine($"Data de empréstimo: {DataEmprestimoInicio}. Data de devolução: {DataEmprestimoInicio.Add(DiasEmprestimo)}");
        }

        public void GerarMulta()
        {
            DiasEmprestimoReal = (DataEmprestimoFinal - DataEmprestimoInicio);

            if (DiasEmprestimoReal > DiasEmprestimo)
            {
                GerouMulta = true;
                Console.WriteLine("O empréstimo gerou multa.");
            }
            else
            {
                GerouMulta = false;
                Console.WriteLine("O empréstimo não gerou multa.");
            }
        }

        public void GerarValorMulta()
        {
            ValorMulta = Convert.ToInt32((DiasEmprestimoReal - DiasEmprestimo).Days) * 2.50; // Cobrado multa R$2.50/dia
            Console.WriteLine($"A multa a ser paga é de R$ {ValorMulta}.");
        }

    }
}
