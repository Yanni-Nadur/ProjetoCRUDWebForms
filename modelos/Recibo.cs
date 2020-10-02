using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace locadoraCarros1.modelos {
    public class Recibo {
        public int IdLocacao { get; set; }
        public int IdCliente { get; set; }
        public String Nome { get; set; }
        public int IdCarro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public DateTime DtLocacao { get; set; }
        public DateTime DtDevolucao { get; set; }
        public decimal ValLocacao { get; set; }

    }
}