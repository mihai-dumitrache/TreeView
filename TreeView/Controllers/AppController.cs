using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TreeView.Models;
using TreeView.Services.Interfaces;

namespace TreeView.Controllers
{
    public class AppController : Controller
    {
        private IAppServices _appService;

        public AppController(IAppServices appService)
        {
            _appService = appService;
        }
        public IActionResult Index()
        {
            List<Task> tasksList = _appService.GetAllTasks();
            return View("Views/Home/Index.cshtml",tasksList);
        }
        public IActionResult AddTask(string taskTitle)
        {
            _appService.AddTask(taskTitle);
            List<Task> tasksList =_appService.GetAllTasks();
            return View("Views/Home/Index.cshtml",tasksList);
        }

        public List<Step> GetAllStepsByTaskId(int taskId)
        {
            Task task=new Task();
            task.StepsList=_appService.GetAllStepsByTaskId(taskId);
            
            return task.StepsList;

        }
    }
}
