using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Elfo : Personagem
    {
        public override void apresentar()
        {
            Console.WriteLine("Elfo");
            Console.WriteLine("Olá, sou o Elfo das terras de Gransgre, conhecido como " + this.Nome + " tenho " + this.Vida + " pontos de vida. Inteligência: " + this.Inteligencia + ", Agilidade: " + this.Agilidade + "Forca: " + this.Forca + ". Meu nível atual é: " + this.Nivel);
        }

    }
}
