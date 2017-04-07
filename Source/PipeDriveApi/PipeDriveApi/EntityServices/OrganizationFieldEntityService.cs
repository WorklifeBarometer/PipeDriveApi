namespace PipeDriveApi.EntityServices
{
    public class OrganizationFieldEntityService<T> : PagingEntityService<T> 
        where T : Field
    {
        public OrganizationFieldEntityService(IPipeDriveClient client) : base(client, "organizationFields") { }
    }
}
