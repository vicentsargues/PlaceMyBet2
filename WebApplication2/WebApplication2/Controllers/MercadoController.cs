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
        public IEnumerable<MercadoDTO> GetDTO()
        {
            var repo = new MercadoRepository();
            List<MercadoDTO> discos = repo.RetrieveDTO();
            return discos;

        }

        // GET: api/Mercados?anyo=valor1&anyofin=valor2

        public Mercado Get(int id)
        {

            var repo = new MercadoRepository();
            Mercado d = repo.Retrieve(id);
            return d;

        }


        public void Post([FromBody]Mercado Mercado)
        {
            var repo = new MercadoRepository();
            repo.Save(Mercado);
        }

        // POST: api/Discos
        //public void Post([FromBody]Disco disco)
        //{
        //    var repo = new DiscosRepository();
        //    repo.Save(disco);
        //}

    }
}

