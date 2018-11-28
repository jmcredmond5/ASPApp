﻿using ASPApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPApp.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin")]
    [SelectedTab("posts")]
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}