using System;

namespace Todoapp.Models;

public class TodoItem
{
    public long id { get; set; }
    public required string name { get; set; }
    public bool isComplete { get; set; }

}
