using javax.jws;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TreeView.Models;
using TreeView.Services.Interfaces;

namespace TreeView.Services
{
    public class AppServices:IAppServices
    {
        private MyContext _context;

        public AppServices()
        {
            _context = new MyContext();
        }

        public int AddTask(string taskTitle)
        {
            Task task=new Task();
            task.TaskTitle=taskTitle;
            _context.Add<Task>(task);
            _context.SaveChanges();
            return 0;
        }

        public List<Task> GetAllTasks()
        {
            TasksList tasksList=new TasksList();
            return tasksList.Tasks=_context.Tasks.ToList();
        }

        public List<Step> GetAllStepsByTaskId(int taskId)
        {
            Task task=new Task();
            task.StepsList=_context.Steps.Where(x => x.Task.Id==taskId).Include(x => x.Task).ToList();
            return task.StepsList;
        }
    }
}
