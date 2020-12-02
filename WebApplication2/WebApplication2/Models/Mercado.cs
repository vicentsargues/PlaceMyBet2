using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Placemybet.Models
{
    public class Mercado
    {
        public Mercado( int MercadoId, string overUnder, double CuotaOver, double DineroOver, double CuotaUnder, double DineroUnder)
        {
            this.MercadoId = MercadoId; 
            OverUnder = overUnder;
            this.CuotaOver = CuotaOver;
            this.DineroOver = DineroOver;
            this.CuotaUnder = CuotaUnder;
            this.DineroUnder = DineroUnder;
            
    }

        public int MercadoId { get; set; }
        public string OverUnder { get; set; }
        public double CuotaOver { get; set; }
        public double DineroOver { get; set; }
        public double CuotaUnder { get; set; }
        public double DineroUnder { get; set; }
        public List<Evento> Eventos { get; set; }
    }


    public class MercadoDTO
    {
        public MercadoDTO(string over_under, double cuota_over, double cuota_under)
        {
            Over_under = over_under;
            Cuota_over = cuota_over;
            Cuota_under = cuota_under;
        }

        public string Over_under { get; set; }
        public double Cuota_over { get; set; }
        public double Cuota_under { get; set; }
    }

}






