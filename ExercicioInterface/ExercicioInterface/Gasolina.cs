using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace ExercicioInterface
{
    public interface IVeiculo
    {
        string Dirigir();
        bool Reabastecer(int quantidadeGasolina);
    }

    public class Carro : IVeiculo
    {
        public int QuantidadeGasolina { get; set; }

        public Carro(int quantidadeGasolina)
        {
            QuantidadeGasolina = quantidadeGasolina;
        }

        public string Dirigir()
        {
            if (QuantidadeGasolina > 0)
                return "Dirigindo";
            else
                return "Sem combustível";
        }

        public bool Reabastecer(int quantidadeGasolina)
        {
            quantidadeGasolina++;
            return true;
        }
    }


}
