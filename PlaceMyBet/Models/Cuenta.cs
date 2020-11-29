using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlaceMyBet.Models
{
    public class Cuenta
    {
        public double saldo { get; set; }
        public string nombreBanco { get; set; }
        public string NumeroCuentaId { get; set; }

        public string emailId { get; set; }
        public Usuario Usuario { get; set; }
    }
}