using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class Deal : BaseEntity
    {
        public int Id { get; set; }
        public Owner CreatorUserId { get; set; }
        public Owner UserId { get; set; }
        public PersonId PersonId { get; set; }
        public OrganizationId OrgId { get; set; }
        public int StageId { get; set; }
        public string Title { get; set; }
        public decimal Value { get; set; }
        public string Currency { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? StageChangeTime { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public string Status { get; set; }
        public DateTime? NextActivityDate { get; set; }
        public DateTime? NextActivityTime { get; set; }
        public int? NextActivityId { get; set; }
        public int? LastActivityId { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string LostReason { get; set; }
        public string VisibleTo { get; set; }
        public DateTime? CloseTime { get; set; }
        public int? PipelineId { get; set; }
        public DateTime? WonTime { get; set; }
        public DateTime? FirstWonTime { get; set; }
        public DateTime? LostTime { get; set; }
        public int ProductsCount { get; set; }
        public int FilesCount { get; set; }
        public int NotesCount { get; set; }
        public int FollowersCount { get; set; }
        public int EmailMessagesCount { get; set; }
        public int DoneActivitiesCount { get; set; }
        public int UndoneActivitiesCount { get; set; }
        public int ReferenceActivitiesCount { get; set; }
        public int ParticipantsCount { get; set; }
        public DateTime? ExpectedCloseDate { get; set; }
        public DateTime? LastIncomingMailTime { get; set; }
        public DateTime? LastOutgoingMailTime { get; set; }
        public int? StageOrderNr { get; set; }
        public string PersonName { get; set; }
        public string OrgName { get; set; }
        public string NextActivitySubject { get; set; }
        public string NextActivityType { get; set; }
        public string NextActivityDuration { get; set; }
        public string NextActivityNote { get; set; }
        public string FormattedValue { get; set; }
        public DateTime? RottenTime { get; set; }
        public decimal WeightedValue { get; set; }
        public string FormattedWeightedValue { get; set; }
        public string OwnerName { get; set; }
        public string CcEmail { get; set; }
        public bool OrgHidden { get; set; }
        public bool PersonHidden { get; set; }
    }
}
