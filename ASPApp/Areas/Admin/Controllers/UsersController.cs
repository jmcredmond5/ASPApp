using ASPApp.Areas.Admin.ViewModels;
using ASPApp.Infrastructure;
using ASPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPApp.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin")]
    [SelectedTab("users")]
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return View(new UsersIndex
            {
                Users = Database.Session.Query<User>().ToList()
            });
        }
    }
}