using CSharpControllerAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharpControllerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<GuestModel> guests = new()
        {
            new GuestModel { Id = 1, FirstName = "AA", LastName = "AA" },
            new GuestModel { Id = 2, FirstName = "BB", LastName = "BB" },
            new GuestModel { Id = 3, FirstName = "CC", LastName = "CC"}
        };

        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<GuestModel> Get()
        {
            return guests.OrderBy(x => x.Id);
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public GuestModel? Get(int id)
        {
            return guests.FirstOrDefault(g => g.Id == id);
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] GuestModel value)
        {
            guests.Add(value);
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] GuestModel value)
        {
            guests.RemoveAll(g => g.Id == id);
            guests.Add(value);
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            guests.RemoveAll(g => g.Id == id);
        }
    }
}
