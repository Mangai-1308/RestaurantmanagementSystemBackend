using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantmanagementSystem.Data;
using RestaurantmanagementSystem.Modals;

namespace RestaurantmanagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public RestaurantController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<Restaurant>>> GetRestaurant()
        {
            var restaurant = await appDbContext.Restaurant.ToListAsync();
            return Ok(restaurant);
        }
    }
}
