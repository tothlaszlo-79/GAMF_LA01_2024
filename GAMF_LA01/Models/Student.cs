using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Metrics;

namespace GAMF_LA01.Models
{
    public class Student
    {
        public int Id { get; set; }
       
        [DisplayName("Családnév")]
        [Required(ErrorMessage ="Családnév kitöltése kötelező")]
        public string LastName { get; set; }
        
        [DisplayName("Keresztnév")]
        [Required(ErrorMessage = "Keresztnév kitöltése kötelező")]
        public string FirstMidName { get; set; }
        
        [DisplayName("Első jelentkezés")]
        [Required(ErrorMessage = "Első jelentkezés kitöltése kötelező")]
        public DateTimeOffset EnrollmentDate { get; set; }
        
        
        [DisplayName("Jelentkezések")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
       
    }
}
