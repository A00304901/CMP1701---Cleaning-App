using CMP1701___Cleaning_App.Droid.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CMP1701___Cleaning_App.Services
{
    public class CleaningTaskService
    {
        private static readonly List<CleaningTask> _tasks = new List<CleaningTask>();

        // Fetch all tasks
        public Task<List<CleaningTask>> GetTasksAsync()
        {
            return Task.FromResult(_tasks);
        }

        // Fetch a single task by ID
        public Task<CleaningTask> GetTaskByIdAsync(int taskId)
        {
            var task = _tasks.Find(t => t.TaskId == taskId);
            return Task.FromResult(task);
        }

        // Add or update a task
        public Task SaveTaskAsync(CleaningTask task)
        {
            var existingTask = _tasks.Find(t => t.TaskId == task.TaskId);
            if (existingTask != null)
            {
                _tasks.Remove(existingTask);
            }
            _tasks.Add(task);
            return Task.CompletedTask;
        }

        // Delete a task
        public Task DeleteTaskAsync(int taskId)
        {
            var task = _tasks.Find(t => t.TaskId == taskId);
            if (task != null)
            {
                _tasks.Remove(task);
            }
            return Task.CompletedTask;
        }
    }
}
