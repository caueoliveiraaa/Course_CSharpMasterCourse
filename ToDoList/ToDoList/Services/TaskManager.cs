using System.Text.RegularExpressions;

namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public class TaskManager {
    /// <summary>
    /// Handles the main exceptions that can occur while running the program.
    /// </summary>
    private List<string> tasks = new List<string>();

    /// <summary>
    /// Handles the main exceptions that can occur while running the program.
    /// </summary>
    public TaskValidator validator = new TaskValidator();

    public void ProcessNewTask(string option, string? task, string? newTask = null)
    {
        validator.ValidateOption(option);

        option = option.ToLower();

        if (option == "display" || option == "1")
        {
            DisplayTasks();
        }
        else if ((option == "insert" || option == "2") && task != null)
        {
            validator.ValidateTask(task, tasks);
            AddTask(task);
        }
        else if ((option == "remove" || option == "3") && task != null)
        {
            validator.ValidateTask(task, tasks);
            RemoveTask(task);
        }
        else if ((option == "edit" || option == "4") && newTask != null && task != null)
        {
            UpdateTask(task, newTask);
        }
    }

    public void DisplayOptions()
    {
        Console.WriteLine("Choose one of the options bellow: ");
        for (int i = 0; i < validator.validOptions.Count; i++)
            if (!Regex.IsMatch(validator.validOptions[i], @"\d"))
                Console.WriteLine($"{i + 1} - {validator.validOptions[i]}");
    }

    private void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine($"Task {task} has been inserted.");
        Console.WriteLine("\n");
    }
    
    private void RemoveTask(string task)
    {
        validator.AuthenticateTask(task, tasks);
        tasks.Remove(task);
        Console.WriteLine($"Task {task} has been removed.");
        Console.WriteLine("\n");
    }

    private void UpdateTask(string oldTask, string newTask)
    {
        validator.AuthenticateTask(oldTask, tasks);
        tasks[tasks.IndexOf(oldTask)] = newTask;
        Console.WriteLine($"Task {oldTask} has been updated to {newTask}.");
        Console.WriteLine("\n");
    }

    private void DisplayTasks()
    {
        if (tasks.Count > 0)
        {
            Console.WriteLine("All tasks:");
            for (int i = 0; i < tasks.Count; i++)
                Console.WriteLine($"Task {i+1}: {tasks[i]}");
        }
        else
        {
            Console.WriteLine("There are no tasks yet.");
        }

        Console.WriteLine("\n");
    }
}
