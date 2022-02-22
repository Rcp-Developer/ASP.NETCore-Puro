using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meu_aula1.Models
{
    public class VendaItem
    {
        private Produto _produto;
        private int _qtde;
        private double _valor;

        public Produto Produto { get => _produto; set => _produto = value; }
        public int Qtde { get => _qtde; set => _qtde = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}
