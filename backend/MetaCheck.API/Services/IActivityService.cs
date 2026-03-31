using System;
using Mapster;
using MetaCheck.API.Dtos;


namespace MetaCheck.API.Services;

public interface IActivityService
{
    List<Activity> GetAll();
    Activity Create(CreateActivityDto dto);
}
