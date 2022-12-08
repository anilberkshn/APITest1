using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestWepApi1.Entities;
using System.Linq;

namespace TestWepApi1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TeacherController : ControllerBase
    {
        public List<Teacher> Teachers = new List<Teacher>()
        {
            new Teacher{Id = 1,Name = "Meral", Surname = "Deniz",Department = "English"},
            new Teacher{Id = 2,Name = "Toprak", Surname = "Yaprak",Department = "Geography"},
            new Teacher{Id = 3,Name = "Arpa", Surname = "Bugday",Department = "Math"},
            new Teacher{Id = 4,Name = "Yağmur", Surname = "Toprak",Department = "Turkish"}
        };
        
        public TeacherController()
        {
            
        }

        [HttpGet("getById")]
        public IActionResult GetById(int id)
        {
            var getId = Teachers.FirstOrDefault(x => x.Id == id);
            return Ok(getId);
        }
        
        [HttpGet ("getAll")]
        public IActionResult GetAll()
        {
            var getAll = Teachers;
            return Ok(getAll);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int id)
        {
            var delete = Teachers.Remove(Teachers.FirstOrDefault(x => x.Id == id));
            
            return Ok(delete);
        }
    }   
}