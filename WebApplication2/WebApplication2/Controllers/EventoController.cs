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
    [Route("api/Eventos/{action}")]
    public class EventoController : ApiController
    {
        /* GET: api/Evento
        [HttpGet]
        [ActionName("Get")]
        public IEnumerable<int> Get()
        {

            return 1;
            //return new EventoRepository().Retrive();
        }

        // GET: api/Evento/5
        [HttpGet]
        [ActionName("GetDTO")]
        public IEnumerable<EventoDTO> GetDTO()
        {
            //  return new EventoRepository().GetEventosDTO();
        }

    */
        public string Get(int id)
        {
  
            return "usu";
        }

        // POST: api/Evento
        [HttpPost]
        [ActionName("Post")]

        public void Post([FromBody]Evento Evento)
        {
            var repo = new EventoRepository();
            repo.Save(Evento);
        }

        // PUT: api/Evento/5
        [HttpPut]
        [Route("api/Eventos/id={id}")]
        public void Put(int id, [FromBody] Evento evento)
        {
            var repo = new EventoRepository();
            repo.Update(id,evento);

        }

        // DELETE: api/Evento/5
        [HttpDelete]
        [Route("api/Eventos/Del/id={id}")]
        public void Delete(int id)
        {

            var repo = new EventoRepository();
            repo.Delete(id);
        }
    }
}
