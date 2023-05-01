using Lab2LinqSchool.Data;
using Lab2LinqSchool.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab2LinqSchool.Controllers
{
    public class InfoController : Controller
    {
        private readonly SchoolContext context;
        public InfoController(SchoolContext _context)
        {
            context = _context;
        }
        public async Task<IActionResult> Index(string SearchString)
        {
            ViewData["CurrentFilter"] = SearchString;
            

            List<InfoViewModel> List = new List<InfoViewModel>();

            var items = await (from tea in context.Teachers
                               join cou in context.Courses on tea.TeacherId equals cou.TeacherId
                               join cla in context.Classes on cou.ClassId equals cla.ClassId
                               join stu in context.Students on cla.ClassId equals stu.StudentId
                               select new
                               { 
                                    TeacherFirstName = tea.TeacherFirstName,
                                    TeacherLastName = tea.TeacherLastName,
                                    CourseName = cou.CourseName,
                                    StudentFirstName = stu.StudentFirstName,
                                    StudentLastName = stu.StudentLastName
                               }).ToListAsync();

            if (!String.IsNullOrEmpty(SearchString))
            {
                items = items.Where(s => s.CourseName.Contains(SearchString)).ToList();
            }

            // Konverterar från anonym
            foreach (var item in items) 
            { 
                InfoViewModel listItem = new InfoViewModel();
                listItem.TeacherFirstName = item.TeacherFirstName;
                listItem.TeacherLastName = item.TeacherLastName;
                listItem.CourseName = item.CourseName;
                listItem.StudentFirstName = item.StudentFirstName;
                listItem.StudentLastName = item.StudentLastName;
                List.Add(listItem);
            }

            return View(List);
        }
    }
}
