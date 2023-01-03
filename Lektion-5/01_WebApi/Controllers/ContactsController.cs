using _01_WebApi.Models;
using _01_WebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace _01_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private static List<ContactPerson> _contacts;
        private FileService _fileService = new FileService();


        public ContactsController()
        {
            var json = _fileService.Read($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file.json");
            try
            {
                _contacts = JsonConvert.DeserializeObject<List<ContactPerson>>(json);
            }
            catch 
            {
                _contacts = new List<ContactPerson>();
            }
        }




        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var contact = _contacts.FirstOrDefault(x => x.Id == Guid.Parse(id));
            if (contact != null)
                return Ok(contact);

            return NotFound();
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_contacts);
        }



        [HttpPost]
        public IActionResult Create(ContactPerson contact)
        {
            _contacts.Add(contact);

            var json = JsonConvert.SerializeObject(_contacts);
            _fileService.Save($@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\file.json", json);
            
            return Ok();
        }






        [HttpPut("{id}")]
        public IActionResult Update(string id, ContactPerson contact)
        {
            return Ok();
        }



        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            return Ok();
        }

    }
}
