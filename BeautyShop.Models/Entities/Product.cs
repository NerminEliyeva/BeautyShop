using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeautyShop.Models.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal DiscountPercent { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public bool IsNew { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; } = new Brand();

        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; } = new SubCategory();

        public List<ProductReview> Reviews { get; set; } = new List<ProductReview>();
        public List<ShoppingCardDetail> ShoppingCardDetails { get; set; } = new List<ShoppingCardDetail>();
    }
}
