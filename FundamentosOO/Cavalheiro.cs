using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Cavalheiro : Personagem
    {
        public override void apresentar()
        {
            Console.WriteLine("Cavalheiro");
            Console.WriteLine("Nome:" + this.Nome + " Nivel:" + this.Nivel + " Força:" + this.Forca + " Agilidade:" + this.Agilidade + " Inteligencia:" + this.Inteligencia + " Vida:" + this.Vida + ".");
        }
    }
}
