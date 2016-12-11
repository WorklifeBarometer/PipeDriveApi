using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Unit { get; set; }
        public decimal Tax { get; set; }
        public bool ActiveFlag { get; set; }
        public bool Selectable { get; set; }
        public string FirstChar { get; set; }
        public string VisibleTo { get; set; }
        public Owner OwnerId { get; set; }
        public int? FilesCount { get; set; }
        public int? FollowersCount { get; set; }
        public DateTime AddTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public List<ProductPrice> Prices { get; set; }
        public List<ProductVariation> ProductVariations { get; set; }
    }

    

    public class ProductPrice
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public decimal Cost { get; set; }
        public decimal OverheadCost { get; set; }
    }


    public class ProductVariation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductId { get; set; }
        public List<ProductVariationPrice> Prices { get; set; }
    }

    public class ProductVariationPrice
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public decimal Cost { get; set; }
        public string Comment { get; set; }
        public decimal Price { get; set; }
        public string PriceFormatted { get; set; }
    }
}
