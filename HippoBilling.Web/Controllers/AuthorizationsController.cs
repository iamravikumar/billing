using HippoBilling.Core.Authorization;
using HippoBilling.Web.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HippoBilling.Web.Controllers
{
    public class AuthorizationsController : HippoControllerBase,IPermissionModule
    {
        //
        // GET: /Authorizations/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            return View();
        }

        public string ModuleName
        {
            get { return "Authorizations"; }
        }


        public int Order
        {
            get { return 2; }
        }
    }
}