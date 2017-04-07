namespace PipeDriveApi.EntityServices
{
    public class NoteEntityService<TNote> : PagingEntityService<TNote>
        where TNote: Note
    {
        public NoteEntityService(IPipeDriveClient client) : base(client, "notes") { }
    }
}
