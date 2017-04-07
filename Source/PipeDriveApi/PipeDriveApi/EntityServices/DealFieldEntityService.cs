namespace PipeDriveApi.EntityServices
{
    public class DealFieldEntityService<T> : PagingEntityService<T>
        where T : Field
    {
        public DealFieldEntityService(IPipeDriveClient client) : base(client, "dealFields") { }
    }
}
