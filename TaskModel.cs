using System.ComponentModel.DataAnnotations;
using TaskManager.Attributes;

namespace TaskManager.Models
{
    public class TaskModel
    {
        // EF Core will configure the database to generate this value
        [Key]
        public int TaskID { get; set; }

        [Required (ErrorMessage = "Please enter a task name.")]
        public string? TaskName { get; set; }

        [StringLength(5000)]
        public string? Description {get; set; }

        [Required (ErrorMessage = "Please enter a due date.")]
        [FutureDate]
        [Display (Name = "Due Date")]
        public DateTime? DueDate { get; set; }

        public string? Slug => TaskName?.Replace(' ', '-').ToLower();

    }
}
