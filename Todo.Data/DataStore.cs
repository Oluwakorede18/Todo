namespace Todo.Data;

using Todo.Models;
public static class DataStore
{
    public static int count = 1; 

    public static Dictionary<string, Command> commandLookup = new()
    {
        { "--add", new Command { Id = 1, Name = "--add", Description = "Adds a new item to the list.", Alias = "-a" } },
        { "--delete", new Command { Id = 2, Name = "--delete", Description = "Removes an item from the list.", Alias = "-d" } },
        { "--complete", new Command { Id = 3, Name = "--complete", Description = "Marks a task as Complete.", Alias = "-c" } },
        { "--help", new Command { Id = 4, Name = "--help", Description = "Prints a list of all available commands.", Alias = "-h" } },
        { "--list", new Command { Id = 5, Name = "--list", Description = "Prints all items in the todo list.", Alias = "-l" } },
        { "--info", new Command { Id = 6, Name = "--info", Description = "Prints details about a particular task on the list", Alias = "-i" } },
        { "--clear", new Command { Id = 7, Name = "--clear", Description = "Clears the list.", Alias = "-cls" } },
    };

    public static List<TodoItem> todoList = new();



}
