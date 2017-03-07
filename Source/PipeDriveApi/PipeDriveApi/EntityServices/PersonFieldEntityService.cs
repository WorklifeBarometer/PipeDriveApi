namespace PipeDriveApi.EntityServices
{
    public class PersonFieldEntityService<T> : PagingEntityService<T>
        where T : Field
    {
        public PersonFieldEntityService(IPipeDriveClient client) : base(client, "personFields") { }
    }
}
