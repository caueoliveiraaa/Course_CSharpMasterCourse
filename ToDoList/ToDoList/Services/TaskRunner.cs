namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public static class TaskRunner
{
    public static void RunProgram()
    {
        do
        {
            try 
            {
                TaskScreen.ShowOptions();
                string? option = Console.ReadLine();

                if (option == null)
                {
                    Console.WriteLine("Option cannot be null!");
                    continue;
                }

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

                TaskManager.ProcessNewTask(option, task, newTask);
            }
            catch (Exception error)
            {
                HandleException(error);
            }
        } while (true);
    }

    private static void HandleException(Exception error)
    {
        if (error is ArgumentNullException)
            Console.WriteLine($"An error with null values occured: {error.Message}");
        else if (error is ArgumentException)
            Console.WriteLine($"The following error occured during runtime: {error.Message}");
        else 
            Console.WriteLine($"An unexpected error occured: {error.Message}");
    }
}
