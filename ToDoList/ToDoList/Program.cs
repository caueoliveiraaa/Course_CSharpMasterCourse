using Course_CSharpMasterCourse.ToDoList.ToDoList;

while (true) {
    try {
        
    }
    catch (Exception error) {
        if (error is ArgumentNullException)
            Console.WriteLine("Argument option is null!");
        else if (error is ArgumentException)
            Console.WriteLine($"The following error occured during runtime: {error.Message}");
        else 
            Console.WriteLine($"An unexpected error occured: {error.Message}");
    }
}
