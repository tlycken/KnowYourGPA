using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnowYourGPA.Web.Models.View;

namespace KnowYourGPA.Web.Controllers
{
    public class StudentsController : Controller
    {
        //
        // GET: /Students/

        public ActionResult Index()
        {
            return View();
        }

    	public ActionResult List()
    	{
    		return View(new List<StudentViewModel>());
    	}
    }
}
