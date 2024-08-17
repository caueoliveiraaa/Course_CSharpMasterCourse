namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public static class TaskScreen {
    public static void FilterTasks()
    {

    }

    public static void ShowOptions()
    {
        Console.WriteLine("Choose one of the options bellow: ");
        for (int i = 0; i < TaskValidator.validOptions.Count; i++)
            Console.WriteLine($"{i + 1} - {TaskValidator.validOptions[i]}");
    }
}