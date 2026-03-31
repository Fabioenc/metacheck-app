using Mapster;
using MetaCheck.API.Dtos;
using MetaCheck.API.Repositories;

namespace MetaCheck.API.Services;

public class ActivityService : IActivityService
{
    private readonly IActivityRepository _repository;

    public ActivityService(IActivityRepository repository)
    {
        _repository = repository;
    }

    public List<Activity> GetAll()
    {
        return _repository.GetAll();
    }

    public Activity Create(CreateActivityDto dto)
    {
        var activity = dto.Adapt<Activity>();

        activity.Id = Guid.NewGuid();
        activity.IsCompleted = false;
        activity.CreatedAt = DateTime.UtcNow;

        return _repository.Add(activity);
    }

}