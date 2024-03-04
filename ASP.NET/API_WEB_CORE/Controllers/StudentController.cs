using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_WEB_CORE.Controllers
{
    //https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        //Get: https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "John", "Jane", "Mark", "Emily", "David" };
            return Ok(studentNames);
        }
    }
}
