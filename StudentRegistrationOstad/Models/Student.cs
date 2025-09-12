using System.ComponentModel.DataAnnotations;

namespace StudentRegistrationOstad.Models
{
    public class Student
    {
        public int Id { get; set; }  // Unique ID for each student

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(16, 65, ErrorMessage = "Age must be between 16 and 65")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Course is required")]
        public string Course { get; set; }
    }
}