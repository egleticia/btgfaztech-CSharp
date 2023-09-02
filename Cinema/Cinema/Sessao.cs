
using System.Data;
using System.Text;

namespace Cinema
{
    internal class Sessao
    {
        private Filme Filme { get; set; }
        private Sala Sala { get; set; }
        private DateTime DataHora { get; set; }

        public Sessao(Sala sala, DateTime dataHora)
        { 
            this.Sala = sala;
            this.DataHora = dataHora;
        }

        public void AdicionaFilme(Filme filme)
        { 
            Filme = filme;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Nome {Filme.Titulo} - {DataHora.ToString("HH:mm - dd:MM:yyyy")}");
            builder.AppendLine($"Sala {Sala.Numero}");

            return builder.ToString();
        }
    }
}
