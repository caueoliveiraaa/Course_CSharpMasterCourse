using System.Collections.Generic;
using Course_CSharpMasterCourse.ToDoList;


namespace Course_CSharpMasterCourse.ToDoList;

public class ToDoListManager : IToDoListManager
{
    private readonly List<Dictionary<int, string>> _database = new List<Dictionary<int, string>>();

    private readonly string _userName;

    public ToDoListManager(string userName)
    {
        this._userName = userName;
    }

    private void AddTask(int index, string task)
    {
        _database.Add(new Dictionary<int, string>()
        {
            { index, task },
        });
    }

    private void RemoveTask(int index, string task)
    {
        _database.RemoveAt(index);
    }
}