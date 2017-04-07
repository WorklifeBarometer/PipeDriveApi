namespace PipeDriveApi.EntityServices
{
    public class UserEntityService<TUser> : EntityService<TUser>
        where TUser : User
    {
        public UserEntityService(IPipeDriveClient client) : base(client, "users") { }
    }
}
