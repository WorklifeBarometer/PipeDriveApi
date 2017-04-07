using System;

namespace PipeDriveApi
{
    public class User : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DefaultCurrency { get; set; }
        public string Locale { get; set; }
        public int Lang { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool Activated { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Modified { get; set; }
        public string SignupFlowVariation { get; set; }
        public bool HasCreatedCompany { get; set; }
        public int IsAdmin { get; set; }
        public int RoleId { get; set; }
        public string TimezoneName { get; set; }
        public bool ActiveFlag { get; set; }
        public string IconUrl { get; set; }
        public bool IsYou { get; set; }
    }
}
