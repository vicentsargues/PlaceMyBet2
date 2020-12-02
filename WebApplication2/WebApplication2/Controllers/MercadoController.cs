using Placemybet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;

namespace Placemybet.Controllers
{
    [Route("api/Mercados/{action}")]
    public class MercadoController : ApiController
    {
    
        // GET: api/Mercados
        public IEnumerable<Mercado> Get()
        {
            var repo = new MercadoRepository();
            List<Mercado> discos = repo.Retrieve();
            return discos;

        }

        // GET: api/Mercados?anyo=valor1&anyofin=valor2
    
        public Mercado Get(int id)
        {

            var repo = new MercadoRepository();
            Mercado d = repo.Retrieve(id);
            return d;

        }

        // POST: api/Discos
        //public void Post([FromBody]Disco disco)
        //{
        //    var repo = new DiscosRepository();
        //    repo.Save(disco);
        //}

    }
}

