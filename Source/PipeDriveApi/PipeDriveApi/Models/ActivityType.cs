using System;

namespace PipeDriveApi
{
    public class ActivityType : BaseEntity
    {
        public int Id { get; set; }
        public int OrderNr { get; set; }
        public string Name { get; set; }
        public string KeyString { get; set; }
        public string IconKey { get; set; }
        public bool ActivityFlag { get; set; }
        public string Color { get; set; }
        public bool IsCustomFlag { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
