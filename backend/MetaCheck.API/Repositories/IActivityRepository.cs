using System;


namespace MetaCheck.API.Repositories;

public interface IActivityRepository
{
    List<Activity> GetAll();
    Activity Add(Activity activity);
}
