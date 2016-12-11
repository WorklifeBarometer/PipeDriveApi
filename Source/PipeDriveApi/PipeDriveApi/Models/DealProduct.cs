using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class DealProduct : BaseEntity
    {
        public int Id { get; set; }
        public int DealId { get; set; }
        public int OrderNr { get; set; }
        public int ProductId { get; set; }
        public int ProductVariationId { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal Duration { get; set; }
        public decimal SumNoDiscount { get; set; }
        public decimal Sum { get; set; }
        public string Currency { get; set; }
        public bool EnabledFlag { get; set; }
        public DateTime AddTime { get; set; }
        public string Comments { get; set; }
        public bool ActiveFlag { get; set; }
        public string Name { get; set; }
        public string SumFormatted { get; set; }
        public int Quantity { get; set; }
    }
}
