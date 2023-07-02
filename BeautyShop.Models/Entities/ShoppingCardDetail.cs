using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Models.Entities
{
    public class ShoppingCardDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();


        public int ShoppingCardId { get; set; }
        public ShoppingCard ShoppingCard { get; set; } = new ShoppingCard();
    }
}
