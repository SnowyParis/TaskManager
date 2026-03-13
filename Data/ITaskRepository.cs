using TaskManager.Models;

namespace TaskManager.Data
{
    public interface ITaskRepository
    {
        IQueryable<TaskModel> GetAllTasks();
        TaskModel GetTaskById(int taskId);
        void AddTask(TaskModel task);
        void UpdateTask(TaskModel task);
        void DeleteTask(TaskModel task);
        void SaveChanges();
    }
}
