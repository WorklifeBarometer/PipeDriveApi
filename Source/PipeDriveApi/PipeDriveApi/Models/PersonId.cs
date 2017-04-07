using System.Collections.Generic;

namespace PipeDriveApi
{
    public class PersonId
    {
        public int Id { get { return Value; } set { Value = value; } }
        public int Value { get; set; }
        public string Name { get; set; }
        public List<Email> Email { get; set; }
        public List<Phone> Phone { get; set; }

        public static implicit operator int(PersonId p) => p?.Value ?? 0;

        public static implicit operator PersonId(int pId) => new PersonId { Value = pId };
        public static bool operator ==(PersonId x, PersonId y) => x?.Value == y?.Value;
        public static bool operator !=(PersonId x, PersonId y) => x?.Value != y?.Value;

        public override bool Equals(object obj)
        {
            return this.Value == (obj as PersonId)?.Value;
        }
        public override int GetHashCode()
        {
            return this.Value;
        }

    }
}