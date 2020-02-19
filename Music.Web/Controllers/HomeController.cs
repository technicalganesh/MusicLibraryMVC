using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Music.Models;
using Music.Standards;
using Music.Web.Models;

namespace Music.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IDataRepository<Composer> _composerRepository;

        public HomeController(ILogger<HomeController> logger, IDataRepository<Composer> composerRepository)
        {
            _logger = logger;
            _composerRepository = composerRepository;
        }

        public IActionResult Index()
        {
            var composers = _composerRepository.GetAll();
            return View(composers);
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Privacy(Composer composer)
        {
            composer.Name = composer.Name + " --- Added.";
            return View(composer);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
