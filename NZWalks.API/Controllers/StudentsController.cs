using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.API.Controllers
{
    // https://localhost:[port_number]/api/students

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //GET: https://localhost:[port_number]/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentName = new String[] { "Chirag Bhat", "Dhanush", "Kavya", "Manasa" };
            return Ok(studentName);
        }
    }
}
