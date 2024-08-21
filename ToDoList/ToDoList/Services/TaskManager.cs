using System.Text.RegularExpressions;

namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public class TaskManager : ITaskManager
{
    /// <summary>
    /// Handles the main exceptions that can occur while running the program.
    /// </summary>
    private List<string> _tasks = new List<string>();

    /// <summary>
    /// Handles the main exceptions that can occur while running the program.
    /// </summary>
    private TaskValidator _validator = new TaskValidator();

    public void ProcessNewTask(string option, string? task, string? newTask = null)
    {
        _validator.ValidateOption(option);

        if (option == "display" || option == "1")
            DisplayTasks();
        else if (option == "clean" || option == "5")
            Console.Clear();
        else
        {
            _validator.ValidateTask(task, _tasks);

            if (option == "insert" || option == "2")
                AddTask(task);
            else if (option == "remove" || option == "3")
                RemoveTask(task);
            else if ((option == "edit" || option == "4") && newTask != null)
                UpdateTask(task, newTask);
        }
    }

    public void DisplayOptions()
    {
        Console.WriteLine("Choose one of the options bellow: ");
        for (int i = 0; i < _validator._validOptions.Count; i++)
            if (!Regex.IsMatch(_validator._validOptions[i], @"\d"))
                Console.WriteLine($"{i + 1} - {_validator._validOptions[i]}");
    }

    /// <summary>
    /// Adds a new task to the tasks property.
    /// </summary>
    private void AddTask(string task)
    {
        _tasks.Add(task);
        Console.WriteLine($"Task '{task}' has been inserted.");
        Console.WriteLine("\n");
    }
    
    /// <summary>
    /// Removes an existing task from the tasks property.
    /// </summary>
    private void RemoveTask(string task)
    {
        if (_validator.AuthenticateTask(task, _tasks))
        {
            _tasks.Remove(task);
            Console.WriteLine($"Task '{task}' has been removed.");
            Console.WriteLine("\n");
        }
        else 
        {
            Console.WriteLine($"Task '{task}' has not been found.");
            Console.WriteLine("\n");
        }
    }

    /// <summary>
    /// Updates the value of an existing task.
    /// </summary>
    private void UpdateTask(string oldTask, string newTask)
    {
        if (_validator.AuthenticateTask(oldTask, _tasks))
        {
            _tasks[_tasks.IndexOf(oldTask)] = newTask;
            Console.WriteLine($"Task '{oldTask}' has been updated to '{newTask}'.");
            Console.WriteLine("\n");
        }
        else
        {
            Console.WriteLine($"Task '{oldTask}' has not been found.");
            Console.WriteLine("\n");
        }
    }

    /// <summary>
    /// Displays all the tasks that have been already added if there are any.
    /// </summary>
    private void DisplayTasks()
    {
        if (_tasks.Count > 0)
        {
            Console.Clear();
            Console.WriteLine("All tasks:");
            for (int i = 0; i < _tasks.Count; i++)
                Console.WriteLine($"{i+1} - {_tasks[i]}");
        }
        else
        {
            Console.WriteLine("There are no tasks yet.");
        }

        Console.WriteLine("\n");
    }
}
