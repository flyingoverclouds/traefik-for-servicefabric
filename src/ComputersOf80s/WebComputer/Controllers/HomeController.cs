using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Fabric;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebComputer.Models;

namespace WebComputer.Controllers
{
    public class HomeController : Controller
    {
        private StatelessServiceContext _svcContext;
        public HomeController(StatelessServiceContext svcContext)
        {
            this._svcContext = svcContext;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = $"You are connected on a application of type : {this._svcContext.CodePackageActivationContext.ApplicationTypeName}";

            ViewData["NodeName"] = this._svcContext.NodeContext.NodeName;
            ViewData["AppInstanceName"] = this._svcContext.ServiceName.Segments[1];
            ViewData["ServiceInstanceName"] = this._svcContext.ServiceName.Segments[2];

            return View("Legacy");
            //return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
