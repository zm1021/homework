using Homework.Models;
using System.Data;
using System.Web.Mvc;
using Homework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {

        Work _work = new Work();






        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Homework(HomeworklViewModel homeworktemp)
        {


            DataTable worktemp = _work.Worktemp();

            homeworktemp.Dt = worktemp;

            return View(homeworktemp);
        }

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        



    }
}