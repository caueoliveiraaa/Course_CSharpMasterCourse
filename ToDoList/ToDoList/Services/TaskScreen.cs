namespace Course_CSharpMasterCourse.ToDoList.ToDoList;

public static class TaskScreen {
    private static List<string> options = new List<string>()
    {

    };

    public static void ReadTask()
    {
        string? name = Console.ReadLine();

        if (name != null) {
            
        }
    }

    public static void ReadNewTask()
    {

    }

    public static void FilterTasks()
    {

    }

    public static void ShowOptions()
    {
        for (int i = 0; i < options.Count; i++)
            Console.WriteLine($"Task {i+1}: {options[i]}");
    }
}