using System;

namespace MetaCheck.API;

public class Activity
{
    public Guid Id { get; set; } // Unique identifier for the activity, guid especially useful for distributed systems
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
