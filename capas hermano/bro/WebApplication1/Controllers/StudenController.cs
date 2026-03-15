using Microsoft.AspNetCore.Mvc;
using School.Infrastructure.Context;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly SchoolContext _context;

        public StudentController(SchoolContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetStudens()
        {
            var studens = _context.Students.ToList();
            return Ok(studens);
        }
    }
}