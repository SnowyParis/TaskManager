using System;
using System.IO.Pipelines;
using TaskManager.Models;

namespace TaskManager.Data
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskContext _taskContext;

        public TaskRepository(TaskContext taskContext)
        {
            _taskContext = taskContext;
        }

        public IQueryable<TaskModel> GetAllTasks()
        {
            return _taskContext.Tasks;
        }

        public void AddTask(TaskModel task)
        {
            _taskContext.Tasks.Add(task);
        }

        public void DeleteTask(TaskModel task)
        {
            _taskContext.Tasks.Remove(task);
        }

        public TaskModel GetTaskById(int taskId)
        {
            return _taskContext.Tasks.FirstOrDefault(t => t.TaskID == taskId);
        }

        public void SaveChanges()
        {
            _taskContext.SaveChanges();
        }

        public void UpdateTask(TaskModel task)
        {
            _taskContext.Tasks.Update(task);
        }
    }
}
