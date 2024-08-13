using System.Text.RegularExpressions;

namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public static class ListManager {
    private static List<string> tasks = new List<string>();
    
    private static List<string> validOptions = new List<string>() {
        "display", "insert", "remove", "edit"
    };

    public static void ProcessNewTask(string option, string task, string? newTask = null) {
        ValidateOption(option);
        ValidateTask(task);

        if (option == "display")
            DisplayTasks();
        else if (option == "insert")
            AddTask(task);
        else if (option == "remove")
            RemoveTask(task);
        else if (option == "edit" && newTask != null)
            UpdateTask(task, newTask);
    }

    private static void ValidateOption(string option) {
        if (option == null)
            throw new ArgumentNullException("Options cannot be null.");
        else if (!validOptions.Contains(option))
            throw new ArgumentException("Invalid option.");
    }

    public static void ValidateTask(string task) {
        if (task == null)
            throw new ArgumentNullException("Tasks cannot be null.");
        else if (task.Length <= 4)
            throw new ArgumentException("Tasks need to have more than 3 letters.");
        else if (!Regex.IsMatch(task, @"\d"))
            throw new ArgumentException("There can be no numbers in the tasks.");
        else if (tasks.IndexOf(task) != -1)
            throw new ArgumentException($"Task {task} already exists.");
    }

    public static void AuthenticateTask(string task) {
        if (tasks.IndexOf(task) == -1)
            throw new ArgumentException($"No task named {task} was found.");        
    }

    public static void AddTask(string task) {
        tasks.Add(task);
    }
    
    public static void RemoveTask(string task) {
        AuthenticateTask(task);
        tasks.Remove(task);
    }

    public static void UpdateTask(string oldTask, string newTask) {
        AuthenticateTask(oldTask);
        tasks[tasks.IndexOf(oldTask)] = newTask;
    }

    public static void DisplayTasks() {
        for (int i = 0; i < tasks.Count; i++)
            Console.WriteLine($"Task {i+1}: {tasks[i]}");
    }
}
