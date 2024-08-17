using Course_CSharpMasterCourse.ToDoList.ToDoList;

try
{
    TaskRunner.RunProgram();
}
catch (Exception error)
{
    if (error is ArgumentNullException)
        Console.WriteLine($"An error with null values occured: {error.Message}");
    else if (error is ArgumentException)
        Console.WriteLine($"The following error occured during runtime: {error.Message}");
    else 
        Console.WriteLine($"An unexpected error occured: {error.Message}");
}
