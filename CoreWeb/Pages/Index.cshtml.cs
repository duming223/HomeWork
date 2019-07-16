using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWeb.Pages.Shared;
using HomeWork._17bang;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class IndexModel : _LayoutModel
    {
        public Student Winner { get; set; }
        public IEnumerable<SelectListItem> Students { get; set; }

        public void OnGet()
        {
            Title = "首页！";

            IList<Student> students= new List<Student>
            {
                new Student{ Id = 1,Name="xingren",Age=20},
                new Student{ Id = 2,Name="duming",Age=20},
                new Student{ Id = 3,Name="meinge",Age=20}
            };

            Students = new SelectList(students, "Id", "Name");
        }

       
    }

    public class Student
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
    }
}
