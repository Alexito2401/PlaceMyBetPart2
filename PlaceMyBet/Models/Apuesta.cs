using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Apuesta
    {
        public int ApuestaId { get; set; }
        public int MercadoId { get; set; }
        public double TipoMercado { get; set; }
        public string tipoApuesta { get; set; }
        public double cuota { get; set; }
        public double dineroApuesta { get; set; }
        public string fecha { get; set; }
        public string emailUsuario { get; set; }
        public int EventoId { get; set; }

        public string Usuarioid { get; set; }
        public Usuario Usuario { get; set; }
        public int Mercadoid { get; set; }
        public Mercado Mercado { get; set; }
    }
}