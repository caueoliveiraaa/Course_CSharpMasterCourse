namespace Course_CSharpMasterCourse.TaskManager;


public interface ITaskManager
{
    /// <summary>
    /// Validates the task and the option and also calls the right operation 
    /// based on the option that has been chosen.
    /// </summary>
    /// <param name="task"> Task to be authenticated. </param>
    /// <param name="tasks"> List of existing tasks. </param>
    /// <param name="newTask"> New task to be processed. </param>
    void ProcessNewTask(string option, string task, string? newTask = null);

    /// <summary>
    /// Displays all the options available for the user.
    /// </summary> 
    void DisplayOptions();
}