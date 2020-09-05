using System;
using System.ComponentModel.DataAnnotations;

namespace admStudentSecurity.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }


        [StringLength(30)]
        [Required(ErrorMessage = "You Must Enter The Field {0}")]
        public string LastName { get; set; }


        [StringLength(30, ErrorMessage = "The Field {0} Must Contain Between {2} and {1} Characters", MinimumLength = 2)]// EL 0 ES LA REFERENCIA
        [Required(ErrorMessage = "You Must Enter The Field {0}")]
        public string FirstName { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }
    }
}