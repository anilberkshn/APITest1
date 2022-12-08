using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TestWepApi1.Entities;

namespace TestWepApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //
    
    public class StudentsController : ControllerBase
    {
        public List<Student> Students = new List<Student>()
        {
            new Student
            {
                Id = 1,
                Name = "Anıl",
                Surname = "Sahin"
            },
            new Student
            {
                Id = 2,
                Name = "arda",
                Surname = "sahin"
            },
            new Student() { Id = 3, Name = "Yasin", Surname = "çakar"}
        };

        public StudentsController()
        {
            
        }
        [HttpGet("{id}",Name = "id")]
        public IActionResult GetById(int id)
        {
            var a =  Students.FirstOrDefault(x => x.Id == id);
            
            return Ok(a);
        }

        [HttpPost]
        public void AddStudent([FromBody]Student student)
        {
          Students.Add(student);
        }

        public JsonResult Deneme(JsonResult deneme)  // 
        {
            return new JsonResult(deneme);
        }
    }
}