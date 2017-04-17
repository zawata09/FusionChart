using FusionChart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FusionChart.Controllers
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
        [HttpGet]
        public JsonResult GetJSON()
       {
            List<UserModel> users = new List<UserModel>();
            users = GetUsersHugeData();
            var allUserList = (from user in users
                               select new
                               {
                                   user.label,
                                   user.value,
                               });
            return Json(allUserList, JsonRequestBehavior.AllowGet);   
        }
        [NonAction]
        private List<UserModel> GetUsersHugeData()
        {
            var usersList = new List<UserModel>();
            UserModel user;
            Random generator = new Random();
            string r = null;
            for (int i = 1; i <= 10; i++)
            {
                user = new UserModel
                {
                   
                    label = "User- " + i,
                    value = generator.Next(0, 1000000).ToString("D6")
                };
                usersList.Add(user);
            }

            return usersList;
        }  
    }
}