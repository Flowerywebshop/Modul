using Bce.Dnn.DNNModule2.Components;
using Bce.Dnn.DNNModule2.Models;
using DotNetNuke.Entities.Users;
using DotNetNuke.Framework.JavaScriptLibraries;
using DotNetNuke.Web.Mvc.Framework.ActionFilters;
using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Bce.Dnn.DNNModule2.Controllers
{
    [DnnHandleError]
    public class FlowerController : DnnController
    {
        [ModuleAction]
        public ActionResult Index()
        {
            var flowers = FlowersManager.Instance.GetFlowers();
            return View(flowers);
        }
    }
}