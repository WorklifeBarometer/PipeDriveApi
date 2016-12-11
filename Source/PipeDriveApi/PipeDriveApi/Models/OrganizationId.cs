namespace PipeDriveApi
{
    public class OrganizationId
    {
        public int Id { get; set; }
        public int Value { get { return Id; } set { Id = value; } }
        public string Name { get; set; }
        public int PeopleCount { get; set; }
        public int OwnerId { get; set; }
        public string Address { get; set; }
        public string CcEmail { get; set; }

        public static implicit operator int(OrganizationId org) => org?.Id ?? 0;

        public static implicit operator OrganizationId(int orgId) => new OrganizationId { Id = orgId };
        public static bool operator ==(OrganizationId x, OrganizationId y) => x?.Id == y?.Id;
        public static bool operator !=(OrganizationId x, OrganizationId y) => x?.Id != y?.Id;

        public override bool Equals(object obj)
        {
            return this.Id == (obj as OrganizationId)?.Id;
        }
        public override int GetHashCode()
        {
            return this.Id;
        }

    }
}