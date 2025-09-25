using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Coupon
    {
        public int Id { get; set; }
        [Required] public string Code { get; set; }
        public decimal DiscountAmount { get; set; }
        public bool IsActive { get; set; }
    }
}
