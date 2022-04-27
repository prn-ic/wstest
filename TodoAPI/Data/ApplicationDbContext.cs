using Microsoft.EntityFrameworkCore;

namespace Todo.Data;

public class ApplicationDbContext: DbContext
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

    public DbSet<TodoItem> Todo => Set<TodoItem>();

}

public class TodoItem
{
    public long Id {get; set;}
    public string Description {get; set;} = string.Empty;
    public bool Completed {get; set;}

}