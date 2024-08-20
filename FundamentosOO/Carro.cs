using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Carro
    {
        //atributoa
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidade { get; set; }
        //metodos

        public void Acelerar()
        {
            this.Velocidade += 5;
            Console.WriteLine("Velocidade atual é " + this.Velocidade + "km/h");
        }
        public void Desacelerar()
        {
            if (this.Velocidade <= 0)
            {
                Console.WriteLine("o carro pifou");
            }
            else
            {
                this.Velocidade -= 5;
                Console.WriteLine("Velocidade atual é " + this.Velocidade + "km/h");
            }
        }
    }
}
