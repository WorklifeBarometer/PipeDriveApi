using System;

namespace PipeDriveApi
{
    public class PictureId
    {
        public int Id { get; set; }
        public int Value { get { return Id; } set { Id = value; } }
        public string ItemType { get; set; }
        public int ItemId { get; set; }
        public bool ActiveFlag { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int AddedByUserId { get; set; }
        public Pictures Pictures { get; set; }
    }
}
