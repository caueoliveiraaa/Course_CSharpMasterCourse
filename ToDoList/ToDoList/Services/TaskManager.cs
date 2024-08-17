
namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public static class TaskManager {

    private static List<string> tasks = new List<string>();
    
    public static void ProcessNewTask(string option, string task, string? newTask = null)
    {
        TaskValidator.ValidateOption(option);
        TaskValidator.ValidateTask(task, tasks);

        if (option == "edit" && newTask != null)
            UpdateTask(task, newTask);
        else if (option == "display")
            DisplayTasks();
        else if (option == "insert")
            AddTask(task);
        else if (option == "remove")
            RemoveTask(task);
    }

    public static void AuthenticateTask(string task)
    {
        if (tasks.IndexOf(task) == -1)
            throw new ArgumentException($"No task named {task} was found.");        
    }

    public static void AddTask(string task)
    {
        tasks.Add(task);
    }
    
    public static void RemoveTask(string task)
    {
        AuthenticateTask(task);
        tasks.Remove(task);
    }

    public static void UpdateTask(string oldTask, string newTask)
    {
        AuthenticateTask(oldTask);
        tasks[tasks.IndexOf(oldTask)] = newTask;
    }

    public static void DisplayTasks()
    {
        for (int i = 0; i < tasks.Count; i++)
            Console.WriteLine($"Task {i+1}: {tasks[i]}");
    }
    
}
