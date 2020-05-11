using DE_Portal.DAL.Interfaces;
using DE_Portal2020.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;

namespace DE_Portal2020.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IKW4 _kw4Repo;
        public HomeController(ILogger<HomeController> logger
            , IKW4 kw4
            )
        {
            _logger = logger;
            _kw4Repo = kw4;
        }


        public IActionResult Index()
        {
            var model = _kw4Repo.GetCharts(Convert.ToInt32(User.Claims.FirstOrDefault(x => x.Type == "UID")?.Value));
            return View(model);
        }

        public IActionResult ITServices()
        {
            return View();
        }
        

        public IActionResult GeneralEscalations()
        {
            return View();
        }

        public IActionResult ServiceLevelAgreements()
        {
            return View();
        }        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
