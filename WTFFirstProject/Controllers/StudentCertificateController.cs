using Microsoft.AspNetCore.Mvc;
using WTFFirstProject.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WTFFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCertificateController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentCertificateController(IStudentService studentService)
        {
            _studentService = studentService;
        }


        // GET: api/<StudentCertificateController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentCertificateController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return _studentService.GetCertificate(id);
        }

        // POST api/<StudentCertificateController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentCertificateController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentCertificateController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
