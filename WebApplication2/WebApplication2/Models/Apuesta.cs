using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Placemybet.Models
{
    public class Apuesta 
    {


        public Apuesta(int ApuestaId, string fecha, int dinero, string mailUsuario, string mercadoOverUnder,int UsuarioId, int EventoId, int MercadoId)
        {
            this.ApuestaId = ApuestaId;
            Fecha = fecha;
            Dinero = dinero;
            MailUsuario = mailUsuario;
            MercadoOverUnder = mercadoOverUnder;
            this.UsuarioId = UsuarioId;
            this.EventoId = EventoId;
            this.MercadoId = MercadoId;
        }



        public int ApuestaId { get; set; }
         public string Fecha { get; set; }
         public int Dinero { get; set; } //añadir cuota
         public double TipoApuesta { get; set; }
         public string MailUsuario { get; set; } //sobra
         public string MercadoOverUnder { get; set; } //sobra

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int EventoId { get; set; } //sobra
        public Evento Evento { get; set; } //sobra

        public int MercadoId { get; set; }
        public Mercado Mercado { get; set; }



    }
    public class ApuestaDTO
    {
        public ApuestaDTO( int iduse, int ideven, int dine,string tipoapuesta)
        {

            iduser = iduse;
            idevent = ideven;         
            dinero = dine;
            tipo = tipoapuesta;

        }

        public int iduser { get; set; }
        public int idevent { get; set; }
        public int dinero { get; set; }
        public string tipo { get; set; }

    }


}
