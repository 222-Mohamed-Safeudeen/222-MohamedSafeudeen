using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> dept = new List<Department>();
            dept.Add(new Department() { DeptID = 101, DeptName = "IT", DeptLoc = "1st block" });
            dept.Add(new Department() { DeptID = 102, DeptName = "CSE", DeptLoc = "2nd block" });

            ViewData["Department"] = dept;

            return View();
        }
    }
}
