using CRUD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        CurdEntities db = new CurdEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudentList()
        {
            List<StudentVM> studlis = db.Students.Where(x => x.isDeleted == false).Select(x => new StudentVM
            {
                StudentId=x.StudentId,
                StudentName=x.StudentName,
                Email=x.Email,
                DepartmentName=x.Department.DepartmentName
            }).ToList();
            return Json(studlis, JsonRequestBehavior.AllowGet);
        }
    }
}