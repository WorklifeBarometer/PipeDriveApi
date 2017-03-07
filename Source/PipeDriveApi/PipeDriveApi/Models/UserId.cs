namespace PipeDriveApi
{
    /// <summary> Used in custom fields </summary>
    public class UserId
    {
        public int Id { get; set; }
        public int Value { get { return Id; } set { Id = value; } }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool HasPic { get; set; }
        public string PicHash { get; set; }
        public bool ActiveFlag { get; set; }

        public static implicit operator int(UserId user) => user?.Id ?? 0;

        public static implicit operator UserId(int id) => new UserId { Id = id };
        public static bool operator ==(UserId x, UserId y) => x?.Id == y?.Id;
        public static bool operator !=(UserId x, UserId y) => x?.Id != y?.Id;

        public override bool Equals(object obj)
        {
            return Value == (obj as PersonId)?.Value;
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}
