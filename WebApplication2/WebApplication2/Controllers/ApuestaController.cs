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
    [Route("api/Apuesta/{action}")]
    public class ApuestaController : ApiController
    {

        // GET: api/Apuesta
       
                [HttpGet]
                [ActionName("Get")]
                public IEnumerable<Apuesta> Get()
        {
                       var repo = new ApuestaRepository();
                       List<Apuesta> discos = repo.Retrieve();
                       return discos;
            ;
        }
        public Apuesta Get(int id)
        {

            var repo = new ApuestaRepository();
            Apuesta d = repo.Retrieve(id);
            return d;

        }
        /*


        // GET: api/Apuesta/5

        [HttpGet]
                [ActionName("GetDTO")]
                public IEnumerable<ApuestaDTO> GetDTO()
                {
                    return new ApuestaRepositorio().GetApuestasDTO();
                }




                [HttpGet]
                [Route("api/Apuesta/over={over}")]
                public IEnumerable<Apuesta> Getover(int over)
                {
                    return new ApuestaRepositorio().Retrive3over(over);
                }



                [HttpGet]
                [Route("api/Apuesta/under={under}")]
                public IEnumerable<Apuesta> Getunder(int under)
                {
                    return new ApuestaRepositorio().Retrive3under(under);
                }
                public String Get(int id)
                {


                    return "2";
                }

                // POST: api/Apuesta
                [HttpPost]
                [ActionName("post")]



                public void Post([FromBody]Apuesta value)
                {
                    var repo = new ApuestaRepositorio();
                    var repo2 = new MercadoRepository();

                    repo2.calcular(value.MercadoOverUnder);
                    repo.Save(value);
                }
                */
        // PUT: api/Apuesta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuesta/5
        public void Delete(int id)
        {
        }
    }
}
