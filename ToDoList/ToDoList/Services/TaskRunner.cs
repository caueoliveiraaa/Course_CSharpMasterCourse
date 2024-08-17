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

                if (!InputIsNotNull(option))
                {
                    Console.WriteLine("Option cannot be null!");
                    continue;
                }

                Console.WriteLine("Type in the task to be stored: ");
                string? task = Console.ReadLine();

                if (!InputIsNotNull(task))
                {
                    Console.WriteLine("Task cannot be null!");
                    continue;
                }
            }
            catch (Exception error)
            {
                HandleException(error);
            }
        } while (true);
    }

    private static bool InputIsNotNull(string? text)
    {
        return text != null;
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
