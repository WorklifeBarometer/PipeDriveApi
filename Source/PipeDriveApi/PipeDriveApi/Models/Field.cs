using System;

namespace PipeDriveApi
{
    public class Field : BaseEntity
    {
        public int? Id { get; set; }
        public string Key { get; set; }
        public string Name { get; set; }
        public int? OrderNr { get; set; }
        public string FieldType { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public bool ActiveFlag { get; set; }
        public bool EditFlag { get; set; }
        public bool? IndexVisibleFlag { get; set; }
        public bool? DetailsVisibleFlag { get; set; }
        public bool? AddVisibleFlag { get; set; }
        public bool? ImportantFlag { get; set; }
        public bool? BulkEditAllowed { get; set; }
        public bool? SearchableFlag { get; set; }
        public string UseField { get; set; }
        public string DisplayField { get; set; }
        public string Link { get; set; }
        //public bool? MandatoryFlag { get; set; } //TODO: can be an object sometimes
        public bool IsSubfield { get; set; } = false;

        //TODO: picklist_data, options
    }
}
