using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Disco
    {
        public int DiscoId { get; set; }
        public string Titulo { get; set; }
        public int Anyo { get; set; }
        public int GrupoId { get; set; }//La entidad dependiente en la relación
        public Grupo Grupo { get; set; } 

        public Disco()
        {

        }

        public Disco(int discoId, string titulo, int anyo, int grupoId/*, Grupo grupo*/)
        {
            DiscoId = discoId;
            Titulo = titulo;
            Anyo = anyo;
            GrupoId = grupoId;
            //Grupo = grupo;
        }               
                
    }
}