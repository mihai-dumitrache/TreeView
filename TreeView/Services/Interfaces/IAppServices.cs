using System.Collections.Generic;
using TreeView.Models;

namespace TreeView.Services.Interfaces
{
    public interface IAppServices
    {
        public int AddTask(string taskTitle);

        public List<Task> GetAllTasks();

        public List<Step> GetAllStepsByTaskId(int taskId);
    }
}
