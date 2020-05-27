using System;
using System.Linq;
using DE_Portal.DAL.Interfaces;
using DE_Portal2020.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DE_Portal2020.Controllers
{
    [Authorize]
    public class CurrentActivitiesController : Controller
    {
        private readonly ILogger<CurrentActivitiesController> _logger;
        private IKW4 _kw4Repo;
        private AppSettings AppSettings { get; set; }
        public CurrentActivitiesController(ILogger<CurrentActivitiesController> logger
            , IKW4 kw4,
            IOptions<AppSettings> appSettings
            )
        {
            _logger = logger;
            _kw4Repo = kw4;
            AppSettings = appSettings.Value;
        }

        public IActionResult Alerts()
        {
            var model = _kw4Repo.GetAlerts(Convert.ToInt32(User.Claims.FirstOrDefault(x => x.Type == "UID")?.Value));
            return View(model);
        }

        public IActionResult Tickets()
        {            
            var model = _kw4Repo.GetTickets(Convert.ToInt32(User.Claims.FirstOrDefault(x => x.Type == "UID")?.Value), User.Claims.FirstOrDefault(x => x.Type == "Email")?.Value, AppSettings.TicketsOnlyAccess, User.Claims.FirstOrDefault(x => x.Type == "Name").ToString() == "RUMC");
            return View(model);
        }

        public IActionResult Projects()
        {
            var model = _kw4Repo.GetProjects(Convert.ToInt32(User.Claims.FirstOrDefault(x => x.Type == "UID")?.Value));
            return View(model);
        }
    }
}