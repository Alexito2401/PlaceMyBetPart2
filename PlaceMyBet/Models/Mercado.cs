using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Mercado
    {
        public int MercadoId { get; set; }
        public double overUnder { get; set; }
        public double coutaOver { get; set; }
        public double cuotaUnder { get; set; }
        public double dineroOver { get; set; }
        public double dineroUnder { get; set; }
        public int idEvento { get; set; }

        public int Eventoid { get; set; }
        public Evento Evento { get; set; }

        public List<Apuesta> Apuestas { get; set; }
    }
}