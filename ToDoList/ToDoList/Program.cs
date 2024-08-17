using Course_CSharpMasterCourse.ToDoList.ToDoList;

try
{
    TaskRunner.RunProgram();
}
catch (Exception error)
{
    Console.WriteLine($"An error occured that has crashed the program: {error.Message}");
}
