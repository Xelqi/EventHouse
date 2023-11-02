using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using mywebapi.Models;

namespace mywebapi.Controllers
{
    [Route("[controller]")]
    public class WishlistController : ControllerBase
    {
        public WishlistController(Database db)
        {
            Db = db;
        }

        // GET api/Wishlist
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            await Db.Connection.OpenAsync();
            var query = new Wishlist(Db);
            var result = await query.GetAllAsync();
            return new OkObjectResult(result);
        }

        // GET api/Wishlist/userID/eventID
        [HttpGet("{userID}/{eventID}")]
        public async Task<IActionResult> GetOne(int userID, int eventID)
        {
            await Db.Connection.OpenAsync();
            var query = new Wishlist(Db);
            var result = await query.FindOneAsync(userID, eventID);
            if (result is null)
                return new NotFoundResult();
            return new OkObjectResult(result);
        }

        // POST api/Wishlist
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Wishlist body)
        {
            await Db.Connection.OpenAsync();
            body.Db = Db;
            int result = await body.InsertAsync();
            return new OkObjectResult(result);
        }

        // DELETE api/Wishlist/userID/eventID
        [HttpDelete("{userID}/{eventID}")]
        public async Task<IActionResult> DeleteOne(int userID, int eventID)
        {
            await Db.Connection.OpenAsync();
            var query = new Wishlist(Db);
            var result = await query.FindOneAsync(userID, eventID);
            if (result is null)
                return new NotFoundResult();
            await result.DeleteAsync();
            return new OkObjectResult(result);
        }

        public Database Db { get; }
    }
}