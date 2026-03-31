using Mapster;
using MetaCheck.API.Dtos;
using MetaCheck.API.Repositories;
using MetaCheck.API.Services;

namespace MetaCheck.API.Endpoints;

public static class ActivityEndpoints
{
    public static void MapActivityEndpoints(this WebApplication app)
    {
        app.MapGet("/api/activities", (IActivityService service) =>
        {
            var activities = service.GetAll();
            var response = activities.Adapt<List<ActivityResponseDto>>();

    return Results.Ok(response);
        });

       app.MapPost("/api/activities", (CreateActivityDto dto, IActivityService service) =>
        {
            var createdActivity = service.Create(dto);
            var response = createdActivity.Adapt<ActivityResponseDto>();

            return Results.Created($"/api/activities/{response.Id}", response);
        });
    }
}