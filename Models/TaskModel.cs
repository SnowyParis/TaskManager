using System.ComponentModel.DataAnnotations;

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
        //[Range()]
        public DateTime? DueDate { get; set; }

        public string? Priority { get; set; }
    }
}
