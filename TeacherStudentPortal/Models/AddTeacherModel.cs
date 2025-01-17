﻿using System.ComponentModel.DataAnnotations;

namespace TeacherStudentPortal.Models
{
    public class AddTeacherModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "CourseTeaching")]
        public string CourseTeaching { get; set; }

        [Required]
        [Display(Name = "CourseId")]
        public int CourseId { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}