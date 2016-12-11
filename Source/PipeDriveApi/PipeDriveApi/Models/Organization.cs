using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class Organization : BaseEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public int OpenDealsCount { get; set; }
        public int RelatedOpenDealsCount { get; set; }
        public int ClosedDealsCount { get; set; }
        public int RelatedClosedDealsCount { get; set; }
        public int EmailMessagesCount { get; set; }
        public int PeopleCount { get; set; }
        public int ActivitiesCount { get; set; }
        public int DoneActivitiesCount { get; set; }
        public int UndoneActivitiesCount { get; set; }
        public int ReferenceActivitiesCount { get; set; }
        public int FilesCount { get; set; }
        public int NotesCount { get; set; }
        public int FollowersCount { get; set; }
        public int WonDealsCount { get; set; }
        public int ReltatedWonDealsCount { get; set; }
        public int LostDealsCount { get; set; }
        public int RelatedLostDealsCount { get; set; }
        public bool ActiveFlag { get; set; }
        public int? CategoryId { get; set; }
        public string PictureId { get; set; }
        public string CountryCode { get; set; }
        public string FirstChar { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? AddTime { get; set; }
        public string VisibleTo { get; set; }
        public DateTime? NextActivityDate { get; set; }
        public DateTime? NextActivityTime { get; set; }
        public int? NextActivityId { get; set; }
        public int? LastActivityId { get; set; }
        public DateTime? LastActivityDate { get; set; }
        public string Address { get; set; }
        public string AddressSubpremise { get; set; }
        public string AddressStreetNumber { get; set; }
        public string AddressRoute { get; set; }
        public string AddressSublocality { get; set; }
        public string AddressLocality { get; set; }
        public string AddressAdminAreaLevel1 { get; set; }
        public string AddressAdminAreaLevel2 { get; set; }
        public string AddressCountry { get; set; }
        public string AddressPostalCode { get; set; }
        public string AddressFormattedAddress { get; set; }
        public string OwnerName { get; set; }
        public string CcEmail { get; set; }

    }
}
