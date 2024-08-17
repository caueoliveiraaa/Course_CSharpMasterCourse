using System.Text.RegularExpressions;

namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public class TaskValidator : ITaskValidator
{
    /// <summary>
    /// All the valid options for the operations available in the program.
    /// </summary>
    public List<string> validOptions = new List<string>()
    {
        "display", "insert", "remove", "edit", "clean",
        "1", "2", "3", "4", "5"
    };

    public bool AuthenticateTask(string task, List<string> tasks) => tasks.IndexOf(task) == -1;

    public void ValidateOption(string option)
    {
        if (!validOptions.Contains(option))
            throw new ArgumentException("An invalid option was detected.");
    }

    public void ValidateTask(string? task, List<string> tasks)
    {
        if (task == null)
            throw new ArgumentException("There cannot be null tasks.");
        else if (task.Length <= 4)
            throw new ArgumentException("Tasks cannot have less than 5 letters.");
        else if (Regex.IsMatch(task, @"\d"))
            throw new ArgumentException("There cannot be numbers in the tasks.");
    }
}
