using System.Text.RegularExpressions;

namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public static class TaskValidator {
    public static List<string> validOptions = new List<string>()
    {
        "display", "insert", "remove", "edit", "1", "2", "3", "4"
    };

    public static void ValidateOption(string option)
    {
        if (!validOptions.Contains(option))
            throw new ArgumentException("Invalid option.");
    }

    public static void ValidateTask(string task, List<string> tasks)
    {
        if (task.Length <= 4)
            throw new ArgumentException("Tasks need to have more than 3 letters.");
        else if (!Regex.IsMatch(task, @"\d"))
            throw new ArgumentException("There can be no numbers in the tasks.");
        else if (tasks.IndexOf(task) != -1)
            throw new ArgumentException($"Task {task} already exists.");
    }
}
