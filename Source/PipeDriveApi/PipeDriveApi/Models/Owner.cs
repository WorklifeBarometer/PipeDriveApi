using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class Owner
    {
        public int Id { get; set; }
        public int Value { get { return Id; } set { Id = value; } }
        public string Name { get; set; }
        public string Email { get; set; }
        public bool? HasPic { get; set; }
        public string PicHash { get; set; }
        public bool ActiveFlag { get; set; }

        public static implicit operator int(Owner owner) => owner?.Id ?? 0;

        public static implicit operator Owner(int ownerId) => new Owner { Id = ownerId };
        public static bool operator == (Owner x, Owner y) => x?.Id == y?.Id; 
        public static bool operator !=(Owner x, Owner y) => x?.Id != y?.Id;

        public override bool Equals(object obj)
        {
            return this.Id == (obj as Owner)?.Id;
        }
        public override int GetHashCode()
        {
            return this.Id;
        }

    }
}
