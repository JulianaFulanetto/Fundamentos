﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        //metodos
        public void QuantidadeEstoque()
        {
            Console.WriteLine("A quantidadeem estoque é: " + this.Estoque);
        }
    }
}
