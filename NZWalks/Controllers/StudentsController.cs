﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentNames = new string[] { "John", "Jane", "Mark", "David", "Emily" };
            return Ok(studentNames);
        }
    }
}
