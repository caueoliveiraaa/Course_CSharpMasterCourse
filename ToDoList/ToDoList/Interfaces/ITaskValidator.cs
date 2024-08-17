namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public interface ITaskValidator
{
    /// <summary>
    /// Validates if the option input by the user is valid.
    /// </summary>
    void ValidateOption(string option);

    /// <summary>
    /// Authenticates the task input by the user.
    /// </summary> 
    /// <param name="task"> Task to be authenticated. </param>
    /// <param name="tasks"> List of existing tasks. </param>
    /// <return> Returns true if the task already exists. </return>
    bool AuthenticateTask(string task, List<string> tasks);

    /// <summary>
    ///  Validates the task input by the user.
    /// </summary>
    /// <param name="task"> Task to be validated. </param>
    /// <param name="tasks"> List of existing tasks. </param>
    void ValidateTask(string? task, List<string> tasks);
}