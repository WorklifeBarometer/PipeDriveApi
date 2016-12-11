namespace PipeDriveApi.EntityServices
{
    public class Sort
    {
        public Sort() { }
        public Sort(string field, SortDirection direction) : this()
        {
            Field = field;
            Direction = direction;
        }
        public string Field { get; set; }
        public SortDirection Direction { get; set; }

        public override string ToString() => $"{Field} {(Direction == SortDirection.Ascending ? "ASC" : "DESC")}";
    }

    public enum SortDirection
    {
        Ascending,
        Descending
    }
}