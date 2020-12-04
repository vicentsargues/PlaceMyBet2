/*using Microsoft.EntityFrameworkCore;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class DiscosRepository
    {
        internal List<Disco> Retrieve()
        {

            List<Disco> discos = new List<Disco>();
            using (PMBContext context = new PMBContext())
            {
                discos = context.Discos.ToList();
            }

            return discos;

        }

        internal Disco Retrieve(int id)
        {
            Disco disco;

            using (PMBContext context = new PMBContext())
            {
                disco = context.Discos
                    .Where(s => s.DiscoId == id)
                    .FirstOrDefault();
            }


            return disco;
        }
        
        internal void Save(Disco d)
        {                       
            PMBContext context = new PMBContext();            
            
            context.Discos.Add(d);
            context.SaveChanges();            

        }
        
    }
}

*/