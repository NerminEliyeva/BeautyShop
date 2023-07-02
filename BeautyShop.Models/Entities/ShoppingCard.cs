using BeautyShop.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyShop.Models.Entities
{
    public class ShoppingCard
    {
        [Key]
        public int Id { get; set; }
     
        //public DateTime ConfirmTime { get; set; }
        public int UserId { get; set; }
        //public User User { get; set; }
        public List<ShoppingCardDetail> ShoppingCardDetails { get; set; } = new List<ShoppingCardDetail>();
    }
}
