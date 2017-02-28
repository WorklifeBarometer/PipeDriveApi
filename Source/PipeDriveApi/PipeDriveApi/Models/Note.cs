using System;

namespace PipeDriveApi
{
    public class Note : BaseEntity
    {
        public int Id { get; set; }
        public int? DealId { get; set; }
        public int? PersonId { get; set; }
        public int? OrgId { get; set; }
        public string Content { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool ActiveFlag { get; set; }
        public bool PinnedToDeal { get; set; }
        public bool PinnedToPerson { get; set; }
        public bool PinnedToOrganization { get; set; }
        public int? LastUpdateUserId { get; set; }
    }
}
