using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Models.Entities
{
    public class ProductReview
    {
        [Key]
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public string ReviewText { get; set; } = string.Empty;
        public int Rating { get; set; }
        public DateTime ReviewDate { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
    }
}
