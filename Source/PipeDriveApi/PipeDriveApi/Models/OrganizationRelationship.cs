using System;

namespace PipeDriveApi
{
    public class OrganizationRelationship : BaseEntity
    {
        public int Id { get; set; }
        public OrganizationId RelOwnerOrgId { get; set; }
        public OrganizationId RelLinkedOrgId { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool ActiveFlag { get; set; }
        public string CalculatedType { get; set; }
        public string RelatedOrganizationName { get; set; }
        public string CalculatedRelatedOrgId { get; set; }
    }
}
