using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Mago : Personagem
    {
        public override void apresentar()
        {
            Console.WriteLine("Mago");
            Console.WriteLine("Olá, sou o mago mais poderoso das terras, conhecido como " + this.Nome + " tenho " + this.Vida + " pontos de vida. Inteligência: " + this.Inteligencia + ", Agilidade: " + this.Agilidade + "Forca: " + this.Forca + ". Meu nível atual é: " + this.Nivel);
        }
    }
}
