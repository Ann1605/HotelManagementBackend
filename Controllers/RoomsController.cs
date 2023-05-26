using HotelManagement.Data;
using HotelManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public RoomsController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;   
        }

        [HttpGet]

        public async Task<ActionResult<List<Rooms>>> GetRooms()
        {
            var hostels = await appDbContext.hostels.ToListAsync();
            return Ok(hostels);
        } 

        [HttpGet("{id:int}")]

        public async Task<ActionResult<Rooms>> GetRooms(int id)
        {
            var hostels = await appDbContext.hostels.FirstOrDefaultAsync(r => r.Id == id );
            if(hostels == null) {
                return Ok(hostels);
            }
            return NotFound();
        }

    }
}
