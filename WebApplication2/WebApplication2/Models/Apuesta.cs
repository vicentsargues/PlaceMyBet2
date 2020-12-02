using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Placemybet.Models
{
    public class Apuesta 
    {


        public Apuesta(int ApuestaId, string fecha, int dinero, double tipoApuesta, string mailUsuario, string mercadoOverUnder)
        {
            this.ApuestaId = ApuestaId;
            Fecha = fecha;
            Dinero = dinero;
            TipoApuesta = tipoApuesta;
            MailUsuario = mailUsuario;
            MercadoOverUnder = mercadoOverUnder;
        }



        public int ApuestaId { get; set; }
         public string Fecha { get; set; }
         public int Dinero { get; set; }
         public double TipoApuesta { get; set; }
         public string MailUsuario { get; set; }
         public string MercadoOverUnder { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int EventoId { get; set; }
        public Evento Evento { get; set; }



    }
    public class ApuestaDTO
    {
        public ApuestaDTO(int email_user, double tipo_apuesta, double cuota, double apuesta, string fecha,  string tipo_apuesta2, double cuota2)
        {

            this.email_user = email_user;
            this.tipo_apuesta = tipo_apuesta;         
            this.cuota = cuota;
            this.apuesta = apuesta;
            this.fecha = fecha;
            this.tipo_apuesta2 = tipo_apuesta2;
            this.cuota2 = cuota2;
        }

        public int email_user { get; set; }
        public double tipo_apuesta { get; set; }
        public string tipo_apuesta2 { get; set; }
        public double cuota { get; set; }
        public double apuesta { get; set; }
        public string fecha { get; set; }

        public double cuota2 { get; set; }
    }


}
