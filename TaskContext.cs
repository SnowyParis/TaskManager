using Microsoft.EntityFrameworkCore;

namespace TaskManager.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options)
            :base(options)
        { }

        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>().HasData(
                new TaskModel 
                {
                    TaskID = 1,
                    TaskName = "Feed dogs",
                    DueDate = new DateTime(2026, 4, 20, 17, 30, 10) // 20/04/2026 at 17:30:10 PM
                },

                new TaskModel
                {
                    TaskID = 2,
                    TaskName = "Edit Presentation",
                    Description = "Edit and submit the Orange presentation for the 28th",
                    DueDate = new DateTime(2026, 4, 28, 9, 40, 0)
                },

                new TaskModel
                {
                    TaskID = 3,
                    TaskName = "Do Laundry",
                    DueDate = new DateTime(2026, 4, 5, 7, 10, 0)
                }

            );
        }
    }
}
