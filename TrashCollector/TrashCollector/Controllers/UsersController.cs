﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Controllers
{
    public class UsersController : Controller
    {
        [Authorize]

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
    }
}