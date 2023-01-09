using _00_WebApi_With_Database.Models;
using _00_WebApi_With_Database.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _00_WebApi_With_Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusesController : ControllerBase
    {
        private readonly StatusService _status;

        public StatusesController(StatusService status)
        {
            _status = status;
        }


        [HttpPost]
        public async Task<IActionResult> Create(StatusRequest req)
        {
            if (await _status.ItemExistsAsync(req.Name))
                return Conflict();

            var result = await _status.CreateAsync(req);
            if (result == true)
                return Ok();

            return BadRequest();
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _status.GetAllAsync());
        }


    }
}
