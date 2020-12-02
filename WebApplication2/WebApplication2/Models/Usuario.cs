using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Placemybet.Models
{
    public class Usuario
    {
        public Usuario(string UsuarioId, string nombre, string apellidos, int edad, int idCuenta)
        {
            this.UsuarioId = UsuarioId;
            Nombre = nombre;
            Apellidos = apellidos;
            Edad = edad;
            IdCuenta = idCuenta;
        }

        public string UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public int IdCuenta { get; set; }

        public int CuentaId { get; set; }
        public Cuenta Cuenta { get; set; }

        public List<Apuesta> Apuesta { get; set; }

    }
}