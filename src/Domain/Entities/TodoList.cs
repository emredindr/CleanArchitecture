﻿namespace CleanArchitecture.Domain.Entities;

public class TodoList : BaseAuditableEntity
{
    public string? Title { get; set; }

    public Colour Colour { get; set; } = Colour.Yellow;

    public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();
}
