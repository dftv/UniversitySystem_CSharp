﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Backend.ModelView
{
    public class SubjectGetAllView
    {
        [Required(ErrorMessage = "{0} is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} is required")]

        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public int CourseId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public int TeacherId { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string TeacherName { get; set; }
    }
}
