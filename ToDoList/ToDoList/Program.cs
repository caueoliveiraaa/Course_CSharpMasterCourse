using Course_CSharpMasterCourse.ToDoList.ToDoList;

try
{
    TaskRunner mainTask = new TaskRunner();
    mainTask.RunProgram();
}
catch (Exception error)
{
    Console.WriteLine($"An error occured, crashing the app: {error.Message}");
}
