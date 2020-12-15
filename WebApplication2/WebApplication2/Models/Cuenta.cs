using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Placemybet.Models
{
    public class Cuenta
    {
        public Cuenta(int CuentaId, int saldo, string nombre, string tarjeta)
        {
            this.CuentaId = CuentaId;
            Saldo = saldo;
            Nombre = nombre;
            Tarjeta = tarjeta;

            
    }

        public int CuentaId { get; set; }
       public int Saldo { get; set; }
       public string Nombre { get; set; }
       public string Tarjeta { get; set; } //añadir usuario id
        public Usuario Usuario { get; set; }

    }
}