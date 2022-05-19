namespace Todo.Models;
public class TodoItem
{
    public TodoItem(string name, int id)
    {
        Name = name;            
        Id = id;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime Created { get; set; } = DateTime.UtcNow;
    public DateTime Updated { get; set; } = DateTime.UtcNow;

}
