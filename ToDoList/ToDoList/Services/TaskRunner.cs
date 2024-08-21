namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public class TaskRunner : ITaskRunner
{
    /// <summary>
    /// Contains an intance of the class TaskManager to manipulate tasks.
    /// </summary>
    private TaskManager _manager = new TaskManager();

    /// <summary>
    /// Controls whether the program keeps running.
    /// </summary>
    private bool _keepRunning = true;

    public void RunProgram()
    {
        SetUpKeyboardInterrunption();
        Console.Clear();
        Console.WriteLine("The program has started...");

        do
        {
            try 
            {
                _manager.DisplayOptions();

                string option = GetOption();
                string task =  GetTask(option);
                string? newTask = null;
                
                if (option == "edit" || option == "4")
                    newTask = GetNewTask();

                _manager.ProcessNewTask(option, task, newTask);
            }
            catch (Exception error)
            {
                HandleException(error);
            }
        } while (_keepRunning);
    }

    /// <summary>
    /// Reads the new input task from the user.
    /// </summary>
    /// <returns> New task typed in by the user. </returns>
    private string GetNewTask()
    {
        Console.WriteLine("Insert new task: ");
        Console.Write(">> ");
        string? newTask = Console.ReadLine();

        if (newTask == null)
            throw new ArgumentException("New task cannot be null.");

        return newTask;
    }

    /// <summary>
    /// Reads the input task from the user.
    /// </summary>
    /// <param name="option"> Option typed in by the user. </param>
    /// <returns> Task typed in by the user. </returns>
    private string GetTask(string option)
    {
        InformTaskOperation(option);
        Console.Write(">> ");
        string? task = Console.ReadLine();

        if (task == null)
            throw new ArgumentException("Task cannot be null.");

        return task;
    }

    /// <summary>
    /// Informs the operation to be executed.
    /// </summary>
    /// <param name="option"> Option typed in by the user. </param>
    private void InformTaskOperation(string option)
    {
        if (option != "display" && option != "1"
            && option != "clean" && option != "5")
        {
            if (option == "insert" || option == "2")
                Console.Write("Type in the task to be stored:\n");
            else if (option == "remove" || option == "3")
                Console.Write("Type in the task to be removed:\n");
            else if (option == "edit" || option == "4")
                Console.Write("Type in the task to be updated:\n");
        }
    }

    /// <summary>
    /// Reads the input option from the user.
    /// </summary>
    /// <returns> Option typed in by the user. </returns>
    private string GetOption()
    {
        Console.Write(">> ");
        string? option = Console.ReadLine();

        if (option == null)
            throw new ArgumentException("Option cannot be null!");

        return option.ToLower();
    }

    /// <summary>
    /// Handles the main exceptions that can occur while running the program.
    /// </summary>
    /// <param name="error"> Exception to be interpreted by the method. </param>
    private void HandleException(Exception error)
    {
        if (error is ArgumentNullException)
            Console.WriteLine($"An error with null values occured: {error.Message}");
        else if (error is ArgumentException)
            Console.WriteLine($"The following error occured during runtime: {error.Message}");
        else
            Console.WriteLine($"An unexpected error occured: {error.Message}");
    }

    /// <summary>
    /// Serves as an exit point for the program.
    /// </summary>
    /// <param></param>
    private void OnExit(object? sender, ConsoleCancelEventArgs args) => Environment.Exit(0);

    /// <summary>
    /// Sets up the keyboard interruption treatment.
    /// </summary>
    private void SetUpKeyboardInterrunption() => Console.CancelKeyPress += new ConsoleCancelEventHandler(OnExit);
}
