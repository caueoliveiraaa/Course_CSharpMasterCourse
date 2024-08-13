using System.Text.RegularExpressions;

namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public static class ListManager {
    private static List<string> tasks = new List<string>();
    
    private static List<string> validOptions = new List<string>() {
        "display", "insert", "remove", "edit"
    };

    public static void ProcessNewTask(string option, string task) {
        ValidateData(option, task);

        if (option == "display") {}
        else if (option == "insert") {}
        else if (option == "remove") {}
        else if (option == "edit") {}
    }

    private static void ValidateData(string option, string task) {
        ValidateTask(task);

        if (option == null || task == null)
            throw new ArgumentNullException("Arguments cannot is null.");
        else if (!validOptions.Contains(option))
            throw new ArgumentException("Invalid option.");
    }

    public static void ValidateTask(string task) {
        if (task.Length <= 4)
            throw new ArgumentException("Tasks need to have more than 3 letters!");
        else if (!Regex.IsMatch(task, @"\d"))
            throw new ArgumentException("There can be no numbers in the tasks!");
    }

    public static void AddTask(string task) {
        tasks.Add(task);
    }
    
    public static void RemoveTask(string task) {
        tasks.Remove(task);
    }

    public static void UpdateTask(string oldTask, string newTask) {
        int index = tasks.IndexOf(oldTask);
        if (index == -1)
            throw new ArgumentException($"No task named {oldTask} was found.");

        AddTask(newTask);
    }

    public static void ShowTasks() {
        for (int i = 0; i < tasks.Count; i++)
            Console.WriteLine($"Item {i+1}: {tasks[i]}");
    }
}
