using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meu_aula1.Models
{
    public class Venda
    {
        private Usuario _usuario;
        private DateTime _data;
        private double _total;
        private List<VendaItem> _itens = new List<VendaItem>();

        public Usuario Usuario { get => _usuario; set => _usuario = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public double Total { get => _total; set => _total = value; }
        public List<VendaItem> Itens { get => _itens; set => _itens = value; }
    }
}
