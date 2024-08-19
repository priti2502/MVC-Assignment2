using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreAssignment.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required")]
        [RegularExpression("[a-zA-Z ]+", ErrorMessage ="Only Alphabets are allowed")]
        [MinLength(15,ErrorMessage ="Min 15 character required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Date of birth is required")]
        [Validation]
        public DateTime DateOfBirth {  get; set; }
        [DateOFJoiningValidation]
        public DateTime DateOfJoining {  get; set; }
        [Range(12000,60000,ErrorMessage ="Salary should be between 12000 and 60000")]
        
        public double Salary { get; set; }
        [DeptValidation]
        public string Dept {  get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }




        [NotMapped]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ReTypePassword { get; set; }



    }
}
