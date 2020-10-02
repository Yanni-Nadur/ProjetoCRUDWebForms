using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace locadoraCarros1.modelos {
    public class Carro {
        public int IdCarro { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public decimal ValSemanal { get; set; }
    }
}