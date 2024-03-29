﻿using Backend.Models.Courses;
using Backend.ModelView;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoursesController : Controller
    {
        private ICoursesRepository _repository;

        public CoursesController(ICoursesRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("Add")]
        public IActionResult Add([FromBody] CourseAddView Course)
        {
            bool res = _repository.Add(Course);

            if (res)
                return Ok(new ResponseModel() { Message = "Successfully registered course!" });
            else
                return Ok(new ResponseModel() { Message = "Error registering course!" });
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            IEnumerable<CoursesModel> courses = _repository.GetAll();

            return Ok(courses);
        }

        [HttpGet("HomeGetAll")]
        public IActionResult HomeGetAll()
        {
            IEnumerable<CourseHomeGetAllView> courses = _repository.HomeGetAll();

            return Ok(courses);
        }

        [HttpGet("GetById/{Id}")]
        public IActionResult GetById([Required] int Id)
        {
            CoursesModel course = _repository.GetById(Id);

            return Ok(course);
        }

        [HttpPut("UpdateById")]
        public IActionResult UpdateById([FromBody] CourseUpdateByIdView Course)
        {
            bool res = _repository.UpdateById(Course);

            if (res)
                return Ok(new ResponseModel() { Message = "Course registration changed successfully!" });
            else
                return Ok(new ResponseModel() { Message = "Error when changing course registration!" });
        }

        [HttpDelete("DeleteById/{Id}")]
        public IActionResult DeleteById([Required] int Id)
        {
            bool res = _repository.DeleteById(Id);

            if (res)
                return Ok(new ResponseModel() { Message = "Course registration successfully deleted!" });
            else
                return Ok(new ResponseModel() { Message = "Error deleting Course record!" });
        }
    }
}
