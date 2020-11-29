using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace PlaceMyBet.Models
{
    public class Evento
    {
        public int EventoId { get; set; }
        public string equipoLocal { get; set; }
        public string equipoVisitante { get; set; }
        public string fecha { get; set; }

        public List<Mercado> Mercados { get; set; }
    }
}