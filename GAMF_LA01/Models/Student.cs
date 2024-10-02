using System.Net.Http.Metrics;

namespace GAMF_LA01.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTimeOffset EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
       
    }
}
