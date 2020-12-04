using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Placemybet.Models
{
    public class Apuesta 
    {


        public Apuesta(int ApuestaId, string fecha, int dinero, string mailUsuario, string mercadoOverUnder ,int MercadoId)
        {
            this.ApuestaId = ApuestaId;
            Fecha = fecha;
            Dinero = dinero;
            MailUsuario = mailUsuario;
            MercadoOverUnder = mercadoOverUnder;
            this.MercadoId = MercadoId;
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

        public int MercadoId { get; set; }
        public Mercado Mercado { get; set; }



    }
    public class ApuestaDTO
    {
        public ApuestaDTO( double tipo_apuesta, double apuesta, int email_user,int idEvento)
        {

            this.email_user = email_user;
            this.tipo_apuesta = tipo_apuesta;         
            this.apuesta = apuesta;
            this.evento = idEvento;

        }

        public int email_user { get; set; }
        public double tipo_apuesta { get; set; }
        public double apuesta { get; set; }
        public int evento { get; set; }

    }


}
