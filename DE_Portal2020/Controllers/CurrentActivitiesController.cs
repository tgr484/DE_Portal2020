using System;
using System.Linq;
using DE_Portal.DAL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DE_Portal2020.Controllers
{
    [Authorize]
    public class CurrentActivitiesController : Controller
    {
        private readonly ILogger<CurrentActivitiesController> _logger;
        private IKW4 _kw4Repo;
        public CurrentActivitiesController(ILogger<CurrentActivitiesController> logger
            , IKW4 kw4
            )
        {
            _logger = logger;
            _kw4Repo = kw4;
        }

        public IActionResult Alerts()
        {
            var model = _kw4Repo.GetAlerts(Convert.ToInt32(User.Claims.FirstOrDefault(x => x.Type == "UID")?.Value));
            return View(model);
        }
    }
}