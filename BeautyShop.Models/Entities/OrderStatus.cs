using BeautyShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Models.Entities
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }

        public OrderStatusEnum Status { get; set; }

        public int ShoppingCardId { get; set; }
        public ShoppingCard ShoppingCard { get; set; } = new ShoppingCard();

    }
}
