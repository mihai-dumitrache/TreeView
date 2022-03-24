using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TreeView.Models;
using TreeView.Services.Interfaces;

namespace TreeView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAppServices _appService;

        public HomeController(ILogger<HomeController> logger, IAppServices appService)
        {
            _logger = logger;
            _appService = appService;
        }

        public IActionResult Index()
        {
            TasksList tasksList =new TasksList();
            tasksList.Tasks = _appService.GetAllTasks();
            return View(tasksList);
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
