using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Placemybet.Models
{
    public class Evento
    {
        public Evento(int EventoId, string eqLoc, DateTime fecha, string eqVis, string overUnder)
        {
            this.EventoId = EventoId;
            EqLoc = eqLoc;
            Fecha = fecha;
            EqVis = eqVis;
            OverUnder = overUnder;
        }

        public int EventoId { get; set; }
        public string EqLoc { get; set; }
        public DateTime Fecha { get; set; }
        public string EqVis { get; set; }
        public string OverUnder { get; set; }

        public int MercadoId { get; set; }
        public Mercado Mercado { get; set; }

        public List<Apuesta> Apuesta { get; set; }

    }






    public class EventoDTO
    {
        public EventoDTO(string equipo_local, string equipo_visitante, string fecha)
        {

            Equipo_local = equipo_local;
            Equipo_visitante = equipo_visitante;
            Fecha = fecha;
        }

        public string Equipo_local { get; set; }
        public string Equipo_visitante { get; set; }
        public string Fecha { get; set; }
    }
}