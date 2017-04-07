namespace PipeDriveApi.EntityServices
{
    public class ActivityFieldEntityService<T> : PagingEntityService<T>
        where T : Field
    {
        public ActivityFieldEntityService(IPipeDriveClient client) : base(client, "activityFields") { }
    }
}
