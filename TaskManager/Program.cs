using Course_CSharpMasterCourse.TaskManager;


try
{
    TaskRunner mainTask = new TaskRunner();
    mainTask.RunProgram();
}
catch (Exception error)
{
    Console.WriteLine($"An error occured, crashing the app: {error.Message}");
}
