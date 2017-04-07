namespace PipeDriveApi.EntityServices
{
    public class NoteFieldEntityService<T> : PagingEntityService<T>
        where T : Field
    {
        public NoteFieldEntityService(IPipeDriveClient client) : base(client, "noteFields") { }
    }
}
