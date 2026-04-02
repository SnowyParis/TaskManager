using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TaskManager.Models;
using TaskManager.Data;

namespace TaskManager.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskRepository _taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public IActionResult Index()
        {
            return View(_taskRepository.GetAllTasks().OrderBy(t => t.DueDate));
        }

        [HttpGet]
        public IActionResult Add()
        {
            // create new Product object
            TaskModel task = new TaskModel();
            ViewBag.Action = "Add";

            // bind product to AddUpdate view
            return View("AddUpdate", task);
        }

        [HttpGet]
        public IActionResult Update(int id) //updating object
        {
            ViewBag.Action = "Edit";
            //ViewData["TaskEdit"] = "Edit task";
            return View("AddUpdate", _taskRepository.GetTaskById(id));
        }

        [HttpPost]
        public IActionResult Update(TaskModel task) //creating new object or saving changes
        {
            ViewBag.Action = "Edit";
            //ViewData["TaskEdit"] = "Edit task";

            if (ModelState.IsValid)
            {
                try
                {
                    if (task.TaskID == 0)
                    {
                        _taskRepository.AddTask(task);
                    }
                    else
                    {
                        _taskRepository.UpdateTask(task);
                    }

                    _taskRepository.SaveChanges();
                    return RedirectToAction("Index"); //Call action method for Index to go back to list of tasks
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("", "Unable to save changes. " +
                        "Try again, and if the problem persists, " +
                        "see your system administrator.");
                }
            }

            return View("AddUpdate", task); //If ModelState.IsValid is false, the task is sent back to the view to be edited (back to edit in [HttpGet]
        }

        public IActionResult Details(int id)
        {
            return View(_taskRepository.GetTaskById(id));  // passes model to Task/Details view
        }

        [HttpGet]
        public IActionResult Delete(int id) //Triggered when delete button in Task/Details is clicked
        {
            var task = _taskRepository.GetTaskById(id);

            if (task == null)
                return NotFound();
            else
            {
                return View(task); //opens delete view
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteTask(TaskModel task) //Triggered when delete button in Task/Delete (confirmation) is clicked
        {
            if (task != null)
            {
                _taskRepository.DeleteTask(task);
                _taskRepository.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.ErrorMessage = "Unable to Delete task";
                return View(task);
            }
        }
    }
}