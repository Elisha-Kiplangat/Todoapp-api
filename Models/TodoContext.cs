using System;
using Microsoft.EntityFrameworkCore;

namespace Todoapp.Models;

public class TodoContext: DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options) : base(options)
    {

    }
    public DbSet<TodoItem> TodoItems { get; set; }

}
