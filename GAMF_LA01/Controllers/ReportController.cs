using GAMF_LA01.Data;
using GAMF_LA01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GAMF_LA01.Controllers
{
    public class ReportController : Controller
    {
        private readonly GAMFDbContext _context;

        public ReportController(GAMFDbContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }

        public IActionResult EnrollmentDateReport()
        {
            var result = _context.Students.GroupBy(s => s.EnrollmentDate)
                .Select(s => new EnrollmentDateVM
                {
                    EnrollmentDate = s.Key,
                    StudentCount = s.Count()
                });
            //A fenti lambda kifjezés sql ben:
            /*
             select x as 'EnrollmentDate', count(*) from Student
             group by EnrollmentDate
             */

            return View(result.ToList());
        }


        public IActionResult StudentCreditReport()
        {
            var adatok = _context.Students
                .Include(r => r.Enrollments)
                .ThenInclude(x => x.Course)
                .GroupBy(c => c.LastName)
                .Select(e => new StudentReportVM
                {
                    StudentName = e.Key,
                    StudentCredit = e.Sum(s => s.Enrollments.Sum(enr => enr.Course.Credits))
                });
            return View(adatok.ToList());
        }

    }

   

}
