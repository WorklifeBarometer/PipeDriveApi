namespace PipeDriveApi.EntityServices
{
    public class ActivityTypeEntityService<T> : EntityService<T>
        where T : ActivityType
    {
        public ActivityTypeEntityService(IPipeDriveClient client) : base(client, "activityTypes") { }
    }
}
