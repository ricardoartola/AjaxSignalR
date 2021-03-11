using AjaxSignalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxSignalR.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult FromAjax()
        {
            var students = StudentData.GetStudents();
            return PartialView("_StudentList", students);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendToServer(string message) {
            MyHub.UpdateFromServer(message);
            return Content("Request message:"+ message);
        }

        public ActionResult SignalRExample() {
            return View();
        }
    }
}