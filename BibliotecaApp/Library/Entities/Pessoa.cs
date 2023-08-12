
namespace Library.Entities
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        private long CPF { get; set; }
        public int Idade { get; set; }
        private DateTime DataNascimento { get; set; }

        public Pessoa()
        {

        }

        private void FazerAniversario()
        {
            Idade++;
        }




    }
}
