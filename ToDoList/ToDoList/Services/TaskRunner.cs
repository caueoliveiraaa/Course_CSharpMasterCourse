namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public class TaskRunner : ITaskRunner
{
    /// <summary>
    /// Contains an intance of the class TaskManager to manipulate tasks.
    /// </summary>
    private TaskManager manager = new TaskManager();

    public void RunProgram()
    {
        Console.Clear();
        SetUpKeyboardInterrunption();
        Console.WriteLine("The program has started...");

        do
        {
            try 
            {
                manager.DisplayOptions();
                string? option = Console.ReadLine();

                if (option == null)
                {
                    Console.WriteLine("Option cannot be null!");
                    continue;
                }

                option = option.ToLower();
                string? task = null;

                if (option != "display" && option != "1")
                {
                    Console.WriteLine("Type in the task to be stored: ");
                    task = Console.ReadLine();

                    if (task == null)
                    {
                        Console.WriteLine("Task cannot be null.");
                        continue;
                    }
                }

                string? newTask = null;
                if (option == "edit" || option == "4")
                {
                    Console.WriteLine("Insert new task: ");
                    newTask = Console.ReadLine();
                }

                manager.ProcessNewTask(option, task, newTask);
            }
            catch (Exception error)
            {
                HandleException(error);
            }
        } while (true);
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
    private void OnExit(object? sender, ConsoleCancelEventArgs args)
    {
        Console.WriteLine("Keyboard interruption detected. Exiting program...");
        Environment.Exit(0);
    }

    /// <summary>
    /// Sets up the keyboard interruption treatment.
    /// </summary>
    private void SetUpKeyboardInterrunption()
    {
        Console.CancelKeyPress += new ConsoleCancelEventHandler(OnExit);
    }
}
