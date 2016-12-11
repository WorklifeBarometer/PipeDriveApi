using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class Activity : BaseEntity
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? UserId { get; set; }
        public bool Done { get; set; }
        public string Type { get; set; }
        public string ReferenceType { get; set; }
        public int? ReferenceId { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DueTime { get; set; }
        public string Duration { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? MarkedAsDoneTime { get; set; }
        public string Subject { get; set; }
        public int? DealId { get; set; }
        public int? OrgId { get; set; }
        public int? PersonId { get; set; }
        public bool ActiveFlag { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string PersonName { get; set; }
        public string OrgName { get; set; }
        public string Note { get; set; }
        public string DealTitle { get; set; }
        public int? AssignedToUserId { get; set; }
        public int? CreatedByUserId { get; set; }
        public string OwnerName { get; set; }
        public string PersonDropboxBcc { get; set; }
        public string DealDropboxBcc { get; set; }
    }
}
