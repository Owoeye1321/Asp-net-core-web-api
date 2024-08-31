using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnetApi.Controllers
{
    //https://localhost:7068/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //GET:https://localhost:7068/api/students
        [HttpGet()]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "john", "Jane", "Mark" };
            return Ok(new { code = 200, students = studentNames });
        }
        
    }
}
