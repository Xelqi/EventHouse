using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using mywebapi.Models;

namespace mywebapi.Controllers
{
    [Route("[controller]")]
    public class EventController : ControllerBase
    {
        public EventController(Database db)
        {
            Db = db;
        }

        // GET api/Event
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await Db.Connection.OpenAsync();
            var query = new Event(Db);
            var result = await query.GetAllAsync();
            Console.WriteLine("Test");
            return new OkObjectResult(result);
        }

        // GET api/Event/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOne(int id)
        {
            await Db.Connection.OpenAsync();
            var query = new Event(Db);
            var result = await query.FindOneAsync(id);
            if (result is null)
                return new NotFoundResult();
            return new OkObjectResult(result);
        }

        // POST api/Event
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Event body)
        {
            await Db.Connection.OpenAsync();
            body.Db = Db;
            int result = await body.InsertAsync();
            Console.WriteLine("inserted id=" + result);
            return new OkObjectResult(result);
        }

        // PUT api/Event/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOne(int id, [FromBody] Event body)
        {
            await Db.Connection.OpenAsync();
            var query = new Event(Db);
            var result = await query.FindOneAsync(id);
            if (result is null)
                return new NotFoundResult();
            result.artist = body.artist;
            result.location = body.location;
            result.description = body.description;
            result.date = body.date;
            await result.UpdateAsync();
            return new OkObjectResult(result);
        }

        // DELETE api/Event/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOne(int id)
        {
            await Db.Connection.OpenAsync();
            var query = new Event(Db);
            var result = await query.FindOneAsync(id);
            if (result is null)
                return new NotFoundResult();
            await result.DeleteAsync();
            return new OkObjectResult(result);
        }

        public Database Db { get; }
    }
}