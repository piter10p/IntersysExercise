using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace IntersysExercise.Controllers
{
    public class ClientsController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            var context = new DAL.AppDBContext();

            var client = await context.Clients.FindAsync(id);

            if (client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var context = new DAL.AppDBContext();
            var clients = await context.Clients.ToArrayAsync();
            return Ok(clients);
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post([FromBody] Models.Client client)
        {
            try
            {
                var context = new DAL.AppDBContext();
                context.Clients.Add(client);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return InternalServerError();
            }
        }
    }
}
