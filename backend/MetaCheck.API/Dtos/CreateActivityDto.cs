using System;

namespace MetaCheck.API.Dtos;

public class CreateActivityDto
{
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    
}
