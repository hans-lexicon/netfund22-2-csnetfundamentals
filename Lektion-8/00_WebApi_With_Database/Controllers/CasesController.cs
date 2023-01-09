using _00_WebApi_With_Database.Models;
using _00_WebApi_With_Database.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _00_WebApi_With_Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CasesController : ControllerBase
    {
        private readonly CaseService _caseService;

        public CasesController(CaseService caseService)
        {
            _caseService = caseService;
        }


        [HttpPost]
        public async Task<IActionResult> Create(CaseRequest req)
        {
            var result = await _caseService.CreateAsync(req);

            if (result == -1)
                return BadRequest();

            return Ok(result);
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _caseService.GetAllAsync());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _caseService.GetAsync(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
