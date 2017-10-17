using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD.ViewModels
{
    public class StudentVM
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public bool isDeleted { get; set; }
        public string DepartmentName { get; set; }

        public int DepartmentId { get; set; }

    }
}