using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Grupo
    {        
        public int GrupoId { get; set; }
        public string Nombre { get; set; }
        public Disco Disco { get; set; }

        public Grupo() {
            //Disco = new List<Disco>();
        }

        public Grupo(int id, string nombre)
        {
            GrupoId = id;
            Nombre = nombre;
        }

        

    }
}