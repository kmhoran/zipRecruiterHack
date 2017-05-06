using JobBoard.Models.Domain;
using JobBoard.Models.ViewModels;
using JobBoard.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult PublicProfile([FromUri] int id)
        {
            PublicProfileVM vm = ProfileService.GetProfileVM(id);
            return View(vm);
        }


        public ActionResult CompanyProfile()
        {

            return View();
        }

        public ActionResult UserDashboard()
        {

            return View();
        }

        public ActionResult UserJobs()
        {

            return View();
        }


        public ActionResult Skills()
        {

            return View();
        }

        public ActionResult JobPostings()
        {
            JobPostListVM vm = new JobPostListVM { JobPostList = PostService.GetAllJobPosts() };

            return View(vm);
        }
    }
}