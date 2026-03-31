using System;

namespace MetaCheck.API.Repositories;

public class ActivityRepository : IActivityRepository
{
    private static readonly List<Activity> _activities = new();
    public List<Activity> GetAll()
    {
        return _activities;
    }

    public Activity Add(Activity activity)
    {
       _activities.Add(activity);
       return activity;
    }
}
