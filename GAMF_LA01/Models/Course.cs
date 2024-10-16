using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAMF_LA01.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        
        [DisplayName("Tantárgy")]
        [Required(ErrorMessage ="Tantárgynév megadása kötelező")]
        public string Title { get; set; }
        
        [DisplayName("Credit pont")]
        [Required(ErrorMessage = "Creditpont megadása kötelező")]
        public int Credits { get; set; }

        [DisplayName("Tantárgyak")]
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
