namespace Todo.Shared;
public class TodoItem
{
    public long Id {get; set;}
    public string Description {get; set;} = string.Empty;
    public bool Completed {get; set;}

}

public class TodoCreateForm
{
    public string Description {get; set;} = string.Empty;
}

public class TodoUpdateForm
{
    public string Description {get; set;} = string.Empty;
    public bool Completed {get; set;}
}