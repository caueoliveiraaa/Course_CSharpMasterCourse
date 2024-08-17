
namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public static class TaskManager {
    private static List<string> tasks = new List<string>();
    
    public static void ProcessNewTask(string option, string? task, string? newTask = null)
    {
        TaskValidator.ValidateOption(option);

        option = option.ToLower();

        if (option == "display" || option == "1")
        {
            DisplayTasks();
        }
        else if ((option == "insert" || option == "2") && task != null)
        {
            TaskValidator.ValidateTask(task, tasks);
            AddTask(task);
        }
        else if ((option == "remove" || option == "3") && task != null)
        {
            TaskValidator.ValidateTask(task, tasks);
            RemoveTask(task);
        }
        else if ((option == "edit" || option == "4") && newTask != null && task != null)
        {
            UpdateTask(task, newTask);
        }
    }

    private static void AuthenticateTask(string task)
    {
        if (tasks.IndexOf(task) == -1)
            throw new ArgumentException($"No task named {task} was found.");        
    }

    public static void AddTask(string task)
    {
        tasks.Add(task);
        Console.WriteLine($"Task {task} inserted successfully.");
    }
    
    public static void RemoveTask(string task)
    {
        AuthenticateTask(task);
        tasks.Remove(task);
        Console.WriteLine($"Task {task} removed successfully.");
    }

    public static void UpdateTask(string oldTask, string newTask)
    {
        AuthenticateTask(oldTask);
        tasks[tasks.IndexOf(oldTask)] = newTask;
        Console.WriteLine($"Task {oldTask} updated to {newTask} successfully.");
    }

    public static void DisplayTasks()
    {
        Console.WriteLine("All tasks:");
        for (int i = 0; i < tasks.Count; i++)
            Console.WriteLine($"Task {i+1}: {tasks[i]}");
    }
}
