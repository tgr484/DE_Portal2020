using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DE_Portal2020.Models;
using DE_Portal.DAL.Models.DEWeb;
using DE_Portal.DAL.Models.KW4;
using Microsoft.AspNetCore.Identity;
using DE_Portal.DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using DE_Portal.DAL.RawSqlHelpers;
using System.Data;
using Dapper;
using DE_Portal.DAL.Repositories;
using DE_Portal.DAL.Interfaces;
using System.Globalization;

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

        public IActionResult Privacy()
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
