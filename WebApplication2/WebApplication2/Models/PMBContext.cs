using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Placemybet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class PMBContext : DbContext
    {
        public DbSet<Apuesta> Apuestas { get; set; } //Taula
        public DbSet<Cuenta> Cuentas { get; set; } //Taula
        public DbSet<Usuario> Usuarios { get; set; } //Taula
        public DbSet<Mercado> Mercados { get; set; } //Taula
        public DbSet<Evento> Eventos { get; set; } //Taula


        public PMBContext()
        {
        }
        
        public PMBContext(DbContextOptions options)
        : base(options)
        {
        }

        //Mètode de configuració
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            if (!optionsBuilder.IsConfigured)
            {




                optionsBuilder.UseMySql("Server=localhost;Database=mydb2;Uid=root;Pwd=''; SslMode = none");//màquina retos
               
            }
        }

        //Inserció inicial de dades
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Mercado>().HasData(new Mercado(2, "Gamma Ray",1,1,1,1));


        }
    }
}