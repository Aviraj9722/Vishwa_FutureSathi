using FutureSathi.IServices;
using FutureSathi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FutureSathi.Controllers
{
    public class UserController : Controller
    {
        FutureSathiEntities ctx = new FutureSathiEntities();

        MessageCode rep = new MessageCode();

        IUser _user;

        public UserController(IUser m)
        {
            _user = m;
        }



        [HttpPost]

        
        public ActionResult Signin(UserClass obj)
        {
            _user.Signin(obj);
            return Json(obj,JsonRequestBehavior.AllowGet);

        }
    }
}